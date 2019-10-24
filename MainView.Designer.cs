namespace Computers
{
    partial class MainView
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.PowerOn_Button = new System.Windows.Forms.Button();
            this.PressStart_button = new System.Windows.Forms.Button();
            this.Shutdown_Button = new System.Windows.Forms.Button();
            this.PowerOff_Button = new System.Windows.Forms.Button();
            this.radioNotebook = new System.Windows.Forms.RadioButton();
            this.radioPC = new System.Windows.Forms.RadioButton();
            this.radioServer = new System.Windows.Forms.RadioButton();
            this.ComputerType = new System.Windows.Forms.Label();
            this.Powerstate = new System.Windows.Forms.Label();
            this.OSState = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PowerOn_Button
            // 
            this.PowerOn_Button.Location = new System.Drawing.Point(627, 4);
            this.PowerOn_Button.Margin = new System.Windows.Forms.Padding(4);
            this.PowerOn_Button.Name = "PowerOn_Button";
            this.PowerOn_Button.Size = new System.Drawing.Size(165, 64);
            this.PowerOn_Button.TabIndex = 0;
            this.PowerOn_Button.Text = "Подать питание";
            this.PowerOn_Button.UseVisualStyleBackColor = true;
            this.PowerOn_Button.Click += new System.EventHandler(this.PowerOn_Click);
            // 
            // PressStart_button
            // 
            this.PressStart_button.Location = new System.Drawing.Point(627, 75);
            this.PressStart_button.Margin = new System.Windows.Forms.Padding(4);
            this.PressStart_button.Name = "PressStart_button";
            this.PressStart_button.Size = new System.Drawing.Size(165, 64);
            this.PressStart_button.TabIndex = 4;
            this.PressStart_button.Text = "Нажать кнопку Power";
            this.PressStart_button.UseVisualStyleBackColor = true;
            // 
            // Shutdown_Button
            // 
            this.Shutdown_Button.Location = new System.Drawing.Point(627, 146);
            this.Shutdown_Button.Margin = new System.Windows.Forms.Padding(4);
            this.Shutdown_Button.Name = "Shutdown_Button";
            this.Shutdown_Button.Size = new System.Drawing.Size(165, 64);
            this.Shutdown_Button.TabIndex = 5;
            this.Shutdown_Button.Text = "Выключить";
            this.Shutdown_Button.UseVisualStyleBackColor = true;
            this.Shutdown_Button.Click += new System.EventHandler(this.Shutdown_Button_Click);
            // 
            // PowerOff_Button
            // 
            this.PowerOff_Button.Location = new System.Drawing.Point(627, 218);
            this.PowerOff_Button.Margin = new System.Windows.Forms.Padding(4);
            this.PowerOff_Button.Name = "PowerOff_Button";
            this.PowerOff_Button.Size = new System.Drawing.Size(165, 64);
            this.PowerOff_Button.TabIndex = 5;
            this.PowerOff_Button.Text = "Обесточить";
            this.PowerOff_Button.UseVisualStyleBackColor = true;
            // 
            // radioNotebook
            // 
            this.radioNotebook.AutoSize = true;
            this.radioNotebook.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.radioNotebook.Location = new System.Drawing.Point(16, 15);
            this.radioNotebook.Margin = new System.Windows.Forms.Padding(4);
            this.radioNotebook.Name = "radioNotebook";
            this.radioNotebook.Size = new System.Drawing.Size(83, 21);
            this.radioNotebook.TabIndex = 6;
            this.radioNotebook.TabStop = true;
            this.radioNotebook.Text = "Ноутбук";
            this.radioNotebook.UseVisualStyleBackColor = true;
            this.radioNotebook.CheckedChanged += new System.EventHandler(this.RadioNotebook_CheckedChanged);
            // 
            // radioPC
            // 
            this.radioPC.AutoSize = true;
            this.radioPC.Location = new System.Drawing.Point(264, 15);
            this.radioPC.Margin = new System.Windows.Forms.Padding(4);
            this.radioPC.Name = "radioPC";
            this.radioPC.Size = new System.Drawing.Size(203, 21);
            this.radioPC.TabIndex = 7;
            this.radioPC.TabStop = true;
            this.radioPC.Text = "Персональный компьютер";
            this.radioPC.UseVisualStyleBackColor = true;
            this.radioPC.CheckedChanged += new System.EventHandler(this.RadioPC_CheckedChanged);
            // 
            // radioServer
            // 
            this.radioServer.AutoSize = true;
            this.radioServer.Location = new System.Drawing.Point(621, 15);
            this.radioServer.Margin = new System.Windows.Forms.Padding(4);
            this.radioServer.Name = "radioServer";
            this.radioServer.Size = new System.Drawing.Size(77, 21);
            this.radioServer.TabIndex = 8;
            this.radioServer.TabStop = true;
            this.radioServer.Text = "Сервер";
            this.radioServer.UseVisualStyleBackColor = true;
            this.radioServer.CheckedChanged += new System.EventHandler(this.RadioServer_CheckedChanged);
            // 
            // ComputerType
            // 
            this.ComputerType.AutoSize = true;
            this.ComputerType.Location = new System.Drawing.Point(4, 4);
            this.ComputerType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ComputerType.Name = "ComputerType";
            this.ComputerType.Size = new System.Drawing.Size(101, 17);
            this.ComputerType.TabIndex = 9;
            this.ComputerType.Text = "ComputerType";
            // 
            // Powerstate
            // 
            this.Powerstate.AutoSize = true;
            this.Powerstate.Location = new System.Drawing.Point(4, 52);
            this.Powerstate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Powerstate.Name = "Powerstate";
            this.Powerstate.Size = new System.Drawing.Size(78, 17);
            this.Powerstate.TabIndex = 10;
            this.Powerstate.Text = "Powerstate";
            // 
            // OSState
            // 
            this.OSState.AutoSize = true;
            this.OSState.Location = new System.Drawing.Point(4, 100);
            this.OSState.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OSState.Name = "OSState";
            this.OSState.Size = new System.Drawing.Size(61, 17);
            this.OSState.TabIndex = 11;
            this.OSState.Text = "OSState";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.OSState);
            this.panel1.Controls.Add(this.PowerOff_Button);
            this.panel1.Controls.Add(this.Powerstate);
            this.panel1.Controls.Add(this.Shutdown_Button);
            this.panel1.Controls.Add(this.ComputerType);
            this.panel1.Controls.Add(this.PressStart_button);
            this.panel1.Controls.Add(this.PowerOn_Button);
            this.panel1.Location = new System.Drawing.Point(16, 55);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(796, 288);
            this.panel1.TabIndex = 12;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 364);
            this.Controls.Add(this.radioServer);
            this.Controls.Add(this.radioPC);
            this.Controls.Add(this.radioNotebook);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainView";
            this.Text = "Computers";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PowerOn_Button;
        private System.Windows.Forms.Button PressStart_button;
        private System.Windows.Forms.Button Shutdown_Button;
        private System.Windows.Forms.Button PowerOff_Button;
        private System.Windows.Forms.RadioButton radioNotebook;
        private System.Windows.Forms.RadioButton radioPC;
        private System.Windows.Forms.RadioButton radioServer;
        private System.Windows.Forms.Label ComputerType;
        private System.Windows.Forms.Label Powerstate;
        private System.Windows.Forms.Label OSState;
        private System.Windows.Forms.Panel panel1;
    }
}

