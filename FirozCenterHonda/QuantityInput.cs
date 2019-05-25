namespace FirozCenterHonda
{
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;

    public class QuantityInput : Form
    {
        private IContainer components = null;
        private TextBox textBoxQty;

        public QuantityInput()
        {
            this.InitializeComponent();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.textBoxQty = new TextBox();
            base.SuspendLayout();
            this.textBoxQty.Location = new Point(7, 3);
            this.textBoxQty.Name = "textBoxQty";
            this.textBoxQty.Size = new Size(100, 20);
            this.textBoxQty.TabIndex = 0;
            this.textBoxQty.KeyDown += new KeyEventHandler(this.textBoxQty_KeyDown);
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            ////base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(0x74, 0x1a);
            base.ControlBox = false;
            base.Controls.Add(this.textBoxQty);
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "QuantityInput";
            base.StartPosition = FormStartPosition.CenterScreen;
            base.Activated += new EventHandler(this.QuantityInput_Activated);
            base.Deactivate += new EventHandler(this.QuantityInput_Deactivate);
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        private void QuantityInput_Activated(object sender, EventArgs e)
        {
            if (base.Owner != null)
            {
                base.Owner.Enabled = false;
            }
        }

        private void QuantityInput_Deactivate(object sender, EventArgs e)
        {
            if (base.Owner != null)
            {
                base.Owner.Enabled = true;
            }
        }

        private void textBoxQty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AddOrder.qty = int.Parse(this.textBoxQty.Text);
            }
        }
    }
}

