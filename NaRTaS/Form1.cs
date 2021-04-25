using Memory;
using WindowsInput;
using WindowsInput.Events;
using WindowsInput.Events.Sources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NaRTaS
{
    public partial class Form1 : Form
    {
        Mem mem;
        IKeyboardEventSource keyboardEventSource;
        List<InputEvent> keyboardEvents;
        IMouseEventSource mouseEventSource;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mem = new Mem();
            mem.OpenProcess("penumbra");
            keyboardEventSource = null;
            keyboardEvents = new List<InputEvent>();
            timer1.Enabled = true;
            eventsCount.Text = "";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            float player_x = mem.ReadFloat("penumbra.exe+002DCAF0,0x158,0x38,0x274,0x48");
            float player_y = mem.ReadFloat("penumbra.exe+002DCAF0,0x158,0x38,0x274,0x50");
            float player_z = mem.ReadFloat("penumbra.exe+002DCAF0,0x158,0x38,0x274,0x4C");

            string level1 = mem.ReadString("penumbra.exe+002DCAF0,0x174,0x24,0xF4");
            string level2 = mem.ReadString("penumbra.exe+002DCAF0,0x174,0x24,0xF4,0x0");

            float igt = mem.ReadFloat("penumbra.exe+002DCAF0,0x188,0x4C,0x1C");


            playerCoords.Text = $"X: {player_x} | Y: {player_y} | Z: {player_z}";
            inGameTime.Text = $"{igt}";

            if (level1 != null && level1.Length > 0 && !level1.StartsWith("level"))
            {
                levelName.Text = $"{level2}";
            }
            else
            {
                levelName.Text = $"{level1}";
            }
        }

        private async void recordButton_Click(object sender, EventArgs e)
        {
            if (recordButton.Text == "Record")
            {
                recordButton.Text = "Stop record";
                recordButton.Enabled = false;

                await Task.Run(async () =>
                {
                    for (int i = 5; i >= 0; i--)
                    {
                        recordButton.BeginInvoke(new Action(() =>
                        {
                            recordButton.Text = $"Record in {i} seconds";
                        }));
                        await Task.Delay(1000);
                    }
                    recordButton.BeginInvoke(new Action(() =>
                    {
                        recordButton.Text = "Stop record";
                        recordButton.Enabled = true;
                    }));

                    keyboardEventSource = WindowsInput.Capture.Global.KeyboardAsync();
                    keyboardEventSource.KeyEvent += new EventHandler<EventSourceEventArgs<KeyboardEvent>>(AddKeyBoardAction);
                    mouseEventSource = WindowsInput.Capture.Global.MouseAsync();
                    mouseEventSource.MouseEvent += new EventHandler<EventSourceEventArgs<MouseEvent>>(AddMouseAction);
                });
            }
            else
            {
                recordButton.Text = "Record";
                keyboardEventSource.Dispose();
                keyboardEventSource = null;
                mouseEventSource.Dispose();
                mouseEventSource = null;

                foreach (var ev in keyboardEvents)
                {
                    if (ev is KeyboardEvent)
                    {
                        var @event = ev as KeyboardEvent;
                        inputsBox.Items.Add($"{@event.Wait} | {@event.KeyUp} | {@event.KeyDown}");
                    }
                    else if (ev is MouseEvent)
                    {
                        var @event = ev as MouseEvent;
                        inputsBox.Items.Add($"{@event.Wait} | {@event.Move} | {@event.ButtonScroll} | {@event.ButtonDown} | {@event.ButtonUp}");
                    }

                }
                eventsCount.Visible = false;
            }
        }

        public void AddKeyBoardAction(object sender, EventSourceEventArgs<KeyboardEvent> e)
        {
            AddAction(e.Data);
        }

        public void AddMouseAction(object sender, EventSourceEventArgs<MouseEvent> e)
        {
            AddAction(e.Data);
        }

        public void AddAction(InputEvent actionEvent)
        {
            keyboardEvents.Add(actionEvent);
            eventsCount.BeginInvoke(new Action(() =>
            {
                eventsCount.Text = $"{keyboardEvents.Count} event(s) recorded.";
            }));
        }

        private async void playButton_Click(object sender, EventArgs e)
        {
            await Task.Run(async () =>
            {
                for (int i = 5; i >= 0; i--)
                {
                    playButton.BeginInvoke(new Action(() =>
                    {
                        playButton.Text = $"Play in {i} seconds";
                        playButton.Enabled = false;
                    }));
                    await Task.Delay(1000);
                }
                playButton.BeginInvoke(new Action(() =>
                {
                    playButton.Text = "Playing...";
                }));

                var eventBuilder = new EventBuilder();

                foreach (var ev in keyboardEvents)
                {
                    if (ev is KeyboardEvent)
                    {
                        var @event = ev as KeyboardEvent;
                        eventBuilder.Add(@event.Wait).Add(@event.KeyDown).Add(@event.KeyUp);
                    }
                    else if (ev is MouseEvent)
                    {
                        var @event = ev as MouseEvent;
                        eventBuilder.Add(@event.Wait).Add(@event.Move).Add(@event.ButtonScroll).Add(@event.ButtonDown).Add(@event.ButtonUp);
                    }

                }

                await eventBuilder.Invoke();

                playButton.BeginInvoke(new Action(() =>
                {
                    playButton.Text = "Play";
                    playButton.Enabled = true;
                }));
            });
        }

        private void addInput_Click(object sender, EventArgs e)
        {

        }

        private void delInput_Click(object sender, EventArgs e)
        {
            for (int x = inputsBox.SelectedIndices.Count - 1; x >= 0; x--)
            {
                int idx = inputsBox.SelectedIndices[x];
                inputsBox.Items.RemoveAt(idx);
                keyboardEvents.RemoveAt(idx);
            }
        }

        private void clearInputs_Click(object sender, EventArgs e)
        {
            inputsBox.Items.Clear();
            keyboardEvents.Clear();
        }
    }
}
    