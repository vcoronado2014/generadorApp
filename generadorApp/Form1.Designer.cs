namespace generadorApp
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
            this.txtNombrePaquete = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreClase = new System.Windows.Forms.TextBox();
            this.chkInsert = new System.Windows.Forms.CheckBox();
            this.chkUpdate = new System.Windows.Forms.CheckBox();
            this.chkDelete = new System.Windows.Forms.CheckBox();
            this.chkListarTodo = new System.Windows.Forms.CheckBox();
            this.chkListarId = new System.Windows.Forms.CheckBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.brnGenerar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombreWebApi = new System.Windows.Forms.TextBox();
            this.chkGet = new System.Windows.Forms.CheckBox();
            this.chkPost = new System.Windows.Forms.CheckBox();
            this.chkDeleteC = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIndicePost = new System.Windows.Forms.TextBox();
            this.chkObtenerId = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese Nombre del Paquete";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNombrePaquete
            // 
            this.txtNombrePaquete.Location = new System.Drawing.Point(12, 27);
            this.txtNombrePaquete.Name = "txtNombrePaquete";
            this.txtNombrePaquete.Size = new System.Drawing.Size(171, 20);
            this.txtNombrePaquete.TabIndex = 1;
            this.txtNombrePaquete.Text = "VCFramework.Negocio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(228, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ingrese Nombre de la clase";
            // 
            // txtNombreClase
            // 
            this.txtNombreClase.Location = new System.Drawing.Point(231, 27);
            this.txtNombreClase.Name = "txtNombreClase";
            this.txtNombreClase.Size = new System.Drawing.Size(171, 20);
            this.txtNombreClase.TabIndex = 3;
            // 
            // chkInsert
            // 
            this.chkInsert.AutoSize = true;
            this.chkInsert.Checked = true;
            this.chkInsert.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkInsert.Location = new System.Drawing.Point(12, 64);
            this.chkInsert.Name = "chkInsert";
            this.chkInsert.Size = new System.Drawing.Size(52, 17);
            this.chkInsert.TabIndex = 4;
            this.chkInsert.Text = "Insert";
            this.chkInsert.UseVisualStyleBackColor = true;
            // 
            // chkUpdate
            // 
            this.chkUpdate.AutoSize = true;
            this.chkUpdate.Checked = true;
            this.chkUpdate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkUpdate.Location = new System.Drawing.Point(70, 64);
            this.chkUpdate.Name = "chkUpdate";
            this.chkUpdate.Size = new System.Drawing.Size(61, 17);
            this.chkUpdate.TabIndex = 5;
            this.chkUpdate.Text = "Update";
            this.chkUpdate.UseVisualStyleBackColor = true;
            // 
            // chkDelete
            // 
            this.chkDelete.AutoSize = true;
            this.chkDelete.Checked = true;
            this.chkDelete.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDelete.Location = new System.Drawing.Point(137, 64);
            this.chkDelete.Name = "chkDelete";
            this.chkDelete.Size = new System.Drawing.Size(57, 17);
            this.chkDelete.TabIndex = 6;
            this.chkDelete.Text = "Delete";
            this.chkDelete.UseVisualStyleBackColor = true;
            // 
            // chkListarTodo
            // 
            this.chkListarTodo.AutoSize = true;
            this.chkListarTodo.Location = new System.Drawing.Point(200, 64);
            this.chkListarTodo.Name = "chkListarTodo";
            this.chkListarTodo.Size = new System.Drawing.Size(76, 17);
            this.chkListarTodo.TabIndex = 7;
            this.chkListarTodo.Text = "ListarTodo";
            this.chkListarTodo.UseVisualStyleBackColor = true;
            // 
            // chkListarId
            // 
            this.chkListarId.AutoSize = true;
            this.chkListarId.Checked = true;
            this.chkListarId.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkListarId.Location = new System.Drawing.Point(383, 66);
            this.chkListarId.Name = "chkListarId";
            this.chkListarId.Size = new System.Drawing.Size(117, 17);
            this.chkListarId.TabIndex = 8;
            this.chkListarId.Text = "Listar Por Elemento";
            this.chkListarId.UseVisualStyleBackColor = true;
            // 
            // txtResultado
            // 
            this.txtResultado.AcceptsReturn = true;
            this.txtResultado.AcceptsTab = true;
            this.txtResultado.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtResultado.Location = new System.Drawing.Point(0, 103);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtResultado.Size = new System.Drawing.Size(889, 366);
            this.txtResultado.TabIndex = 9;
            // 
            // brnGenerar
            // 
            this.brnGenerar.Location = new System.Drawing.Point(507, 60);
            this.brnGenerar.Name = "brnGenerar";
            this.brnGenerar.Size = new System.Drawing.Size(114, 23);
            this.brnGenerar.TabIndex = 10;
            this.brnGenerar.Text = "Generar DAL";
            this.brnGenerar.UseVisualStyleBackColor = true;
            this.brnGenerar.Click += new System.EventHandler(this.brnGenerar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkObtenerId);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtIndicePost);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtNombreWebApi);
            this.groupBox1.Controls.Add(this.chkGet);
            this.groupBox1.Controls.Add(this.chkPost);
            this.groupBox1.Controls.Add(this.chkDeleteC);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.brnGenerar);
            this.groupBox1.Controls.Add(this.txtNombrePaquete);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.chkListarId);
            this.groupBox1.Controls.Add(this.txtNombreClase);
            this.groupBox1.Controls.Add(this.chkListarTodo);
            this.groupBox1.Controls.Add(this.chkInsert);
            this.groupBox1.Controls.Add(this.chkDelete);
            this.groupBox1.Controls.Add(this.chkUpdate);
            this.groupBox1.Location = new System.Drawing.Point(0, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(889, 94);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(447, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Ingrese nombre WEBApi";
            // 
            // txtNombreWebApi
            // 
            this.txtNombreWebApi.Location = new System.Drawing.Point(450, 27);
            this.txtNombreWebApi.Name = "txtNombreWebApi";
            this.txtNombreWebApi.Size = new System.Drawing.Size(171, 20);
            this.txtNombreWebApi.TabIndex = 16;
            this.txtNombreWebApi.Text = "WebApp.ApiBase";
            // 
            // chkGet
            // 
            this.chkGet.AutoSize = true;
            this.chkGet.Checked = true;
            this.chkGet.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkGet.Location = new System.Drawing.Point(750, 19);
            this.chkGet.Name = "chkGet";
            this.chkGet.Size = new System.Drawing.Size(48, 17);
            this.chkGet.TabIndex = 14;
            this.chkGet.Text = "GET";
            this.chkGet.UseVisualStyleBackColor = true;
            // 
            // chkPost
            // 
            this.chkPost.AutoSize = true;
            this.chkPost.Checked = true;
            this.chkPost.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPost.Location = new System.Drawing.Point(668, 19);
            this.chkPost.Name = "chkPost";
            this.chkPost.Size = new System.Drawing.Size(55, 17);
            this.chkPost.TabIndex = 13;
            this.chkPost.Text = "POST";
            this.chkPost.UseVisualStyleBackColor = true;
            // 
            // chkDeleteC
            // 
            this.chkDeleteC.AutoSize = true;
            this.chkDeleteC.Checked = true;
            this.chkDeleteC.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDeleteC.Location = new System.Drawing.Point(806, 19);
            this.chkDeleteC.Name = "chkDeleteC";
            this.chkDeleteC.Size = new System.Drawing.Size(68, 17);
            this.chkDeleteC.TabIndex = 12;
            this.chkDeleteC.Text = "DELETE";
            this.chkDeleteC.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(750, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Generar Controlador";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(636, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Nombre Indice (Ej. RegId)";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtIndicePost
            // 
            this.txtIndicePost.Location = new System.Drawing.Point(639, 64);
            this.txtIndicePost.Name = "txtIndicePost";
            this.txtIndicePost.Size = new System.Drawing.Size(105, 20);
            this.txtIndicePost.TabIndex = 18;
            // 
            // chkObtenerId
            // 
            this.chkObtenerId.AutoSize = true;
            this.chkObtenerId.Checked = true;
            this.chkObtenerId.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkObtenerId.Location = new System.Drawing.Point(282, 66);
            this.chkObtenerId.Name = "chkObtenerId";
            this.chkObtenerId.Size = new System.Drawing.Size(95, 17);
            this.chkObtenerId.TabIndex = 19;
            this.chkObtenerId.Text = "Obtener Por Id";
            this.chkObtenerId.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 469);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtResultado);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombrePaquete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombreClase;
        private System.Windows.Forms.CheckBox chkInsert;
        private System.Windows.Forms.CheckBox chkUpdate;
        private System.Windows.Forms.CheckBox chkDelete;
        private System.Windows.Forms.CheckBox chkListarTodo;
        private System.Windows.Forms.CheckBox chkListarId;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button brnGenerar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkGet;
        private System.Windows.Forms.CheckBox chkPost;
        private System.Windows.Forms.CheckBox chkDeleteC;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombreWebApi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIndicePost;
        private System.Windows.Forms.CheckBox chkObtenerId;
    }
}

