namespace WinForm.ChatSignalRNetCoreWebAppli
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ctUser = new System.Windows.Forms.TextBox();
            this.ctMessage = new System.Windows.Forms.TextBox();
            this.btSendMessage = new System.Windows.Forms.Button();
            this.btConectar = new System.Windows.Forms.Button();
            this.messagesList = new System.Windows.Forms.ListBox();
            this.ctTo = new System.Windows.Forms.TextBox();
            this.btMsPrivado = new System.Windows.Forms.Button();
            this.btnMsEvent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "User";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Message";
            // 
            // ctUser
            // 
            this.ctUser.Location = new System.Drawing.Point(60, 9);
            this.ctUser.Name = "ctUser";
            this.ctUser.Size = new System.Drawing.Size(100, 20);
            this.ctUser.TabIndex = 2;
            // 
            // ctMessage
            // 
            this.ctMessage.Location = new System.Drawing.Point(60, 43);
            this.ctMessage.Name = "ctMessage";
            this.ctMessage.Size = new System.Drawing.Size(100, 20);
            this.ctMessage.TabIndex = 3;
            // 
            // btSendMessage
            // 
            this.btSendMessage.Location = new System.Drawing.Point(6, 69);
            this.btSendMessage.Name = "btSendMessage";
            this.btSendMessage.Size = new System.Drawing.Size(154, 23);
            this.btSendMessage.TabIndex = 4;
            this.btSendMessage.Text = "Send Message";
            this.btSendMessage.UseVisualStyleBackColor = true;
            this.btSendMessage.Click += new System.EventHandler(this.btSendMessage_Click);
            // 
            // btConectar
            // 
            this.btConectar.Location = new System.Drawing.Point(202, 5);
            this.btConectar.Name = "btConectar";
            this.btConectar.Size = new System.Drawing.Size(75, 23);
            this.btConectar.TabIndex = 5;
            this.btConectar.Text = "Conectar";
            this.btConectar.UseVisualStyleBackColor = true;
            this.btConectar.Click += new System.EventHandler(this.btConectar_Click);
            // 
            // messagesList
            // 
            this.messagesList.FormattingEnabled = true;
            this.messagesList.Location = new System.Drawing.Point(3, 135);
            this.messagesList.Name = "messagesList";
            this.messagesList.Size = new System.Drawing.Size(354, 355);
            this.messagesList.TabIndex = 6;
            // 
            // ctTo
            // 
            this.ctTo.Location = new System.Drawing.Point(202, 34);
            this.ctTo.Name = "ctTo";
            this.ctTo.Size = new System.Drawing.Size(100, 20);
            this.ctTo.TabIndex = 7;
            // 
            // btMsPrivado
            // 
            this.btMsPrivado.Location = new System.Drawing.Point(202, 60);
            this.btMsPrivado.Name = "btMsPrivado";
            this.btMsPrivado.Size = new System.Drawing.Size(75, 23);
            this.btMsPrivado.TabIndex = 8;
            this.btMsPrivado.Text = "Ms Privado";
            this.btMsPrivado.UseVisualStyleBackColor = true;
            this.btMsPrivado.Click += new System.EventHandler(this.btMsPrivado_Click);
            // 
            // btnMsEvent
            // 
            this.btnMsEvent.Location = new System.Drawing.Point(202, 90);
            this.btnMsEvent.Name = "btnMsEvent";
            this.btnMsEvent.Size = new System.Drawing.Size(100, 23);
            this.btnMsEvent.TabIndex = 9;
            this.btnMsEvent.Text = "MsEvent";
            this.btnMsEvent.UseVisualStyleBackColor = true;
            this.btnMsEvent.Click += new System.EventHandler(this.btnMsEvent_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 502);
            this.Controls.Add(this.btnMsEvent);
            this.Controls.Add(this.btMsPrivado);
            this.Controls.Add(this.ctTo);
            this.Controls.Add(this.messagesList);
            this.Controls.Add(this.btConectar);
            this.Controls.Add(this.btSendMessage);
            this.Controls.Add(this.ctMessage);
            this.Controls.Add(this.ctUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ctUser;
        private System.Windows.Forms.TextBox ctMessage;
        private System.Windows.Forms.Button btSendMessage;
        private System.Windows.Forms.Button btConectar;
        private System.Windows.Forms.ListBox messagesList;
        private System.Windows.Forms.TextBox ctTo;
        private System.Windows.Forms.Button btMsPrivado;
        private System.Windows.Forms.Button btnMsEvent;
    }
}

