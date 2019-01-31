using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace WinLossRecorder.Controls
{
    public partial class RecordControl : UserControl
    {
        private int _value;

        public RecordControl()
        {
            InitializeComponent();

            btnAdd.Click += delegate
            {
                Value++;
                Updated?.Invoke(this, EventArgs.Empty);
            };

            btnSubtract.Click += delegate
            {
                Value--;
                Updated?.Invoke(this, EventArgs.Empty);
            };
        }

        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public override string Text
        {
            get => base.Text;
            set
            {
                base.Text = value;
                lblName.Text = value;
            }
        }

        public int Value
        {
            get => _value;
            set
            {
                _value = value;

                textBox1.Text = value.ToString();
            }
        }

        public event EventHandler Updated;
    }
}