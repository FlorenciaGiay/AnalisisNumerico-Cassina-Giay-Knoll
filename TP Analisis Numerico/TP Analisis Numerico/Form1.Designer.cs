namespace TP_Analisis_Numerico
{
    partial class FormPrincipal
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabUnidad1 = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabActividad1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.tabMetodos = new System.Windows.Forms.TabControl();
            this.tabBiseccion = new System.Windows.Forms.TabPage();
            this.tituloSalida = new System.Windows.Forms.GroupBox();
            this.btnObtener_Biseccion = new System.Windows.Forms.Button();
            this.lblIteraciones_Biseccion = new System.Windows.Forms.Label();
            this.lblErrorRelativo_Biseccion = new System.Windows.Forms.Label();
            this.lblSolucionRaiz_Biseccion = new System.Windows.Forms.Label();
            this.lblSolucionTitulo = new System.Windows.Forms.Label();
            this.lblErrorTitulo = new System.Windows.Forms.Label();
            this.lblIteracionesTitulo = new System.Windows.Forms.Label();
            this.tabReglaFalsa = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnObtener_RF = new System.Windows.Forms.Button();
            this.lblIteraciones_RF = new System.Windows.Forms.Label();
            this.lblErrorRelativo_RF = new System.Windows.Forms.Label();
            this.lblSolucionRaiz_RF = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabNewtonRaphson = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnObtener_NR = new System.Windows.Forms.Button();
            this.lblIteraciones_NR = new System.Windows.Forms.Label();
            this.lblErrorRelativo_NR = new System.Windows.Forms.Label();
            this.lblSolucionRaiz_NR = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tabSecante = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnObtener_Secante = new System.Windows.Forms.Button();
            this.lblIteraciones_Secante = new System.Windows.Forms.Label();
            this.lblErrorRelativo_Secante = new System.Windows.Forms.Label();
            this.lblSolucionRaiz_Secante = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.tituloEntrada = new System.Windows.Forms.GroupBox();
            this.lblPuntoInicial = new System.Windows.Forms.Label();
            this.tbxPuntoInicial = new System.Windows.Forms.TextBox();
            this.tbxLD = new System.Windows.Forms.TextBox();
            this.tbxLI = new System.Windows.Forms.TextBox();
            this.tbxMaxIteraciones = new System.Windows.Forms.TextBox();
            this.tbxTolerancia = new System.Windows.Forms.TextBox();
            this.tbxFuncion = new System.Windows.Forms.TextBox();
            this.lblLD = new System.Windows.Forms.Label();
            this.lblLI = new System.Windows.Forms.Label();
            this.lblMaxIteraciones = new System.Windows.Forms.Label();
            this.lblTolerancia = new System.Windows.Forms.Label();
            this.lblFuncion = new System.Windows.Forms.Label();
            this.tabUnidad2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabUnidad1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabActividad1.SuspendLayout();
            this.tabMetodos.SuspendLayout();
            this.tabBiseccion.SuspendLayout();
            this.tituloSalida.SuspendLayout();
            this.tabReglaFalsa.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabNewtonRaphson.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabSecante.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tituloEntrada.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabUnidad1);
            this.tabControl1.Controls.Add(this.tabUnidad2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(824, 445);
            this.tabControl1.TabIndex = 0;
            // 
            // tabUnidad1
            // 
            this.tabUnidad1.Controls.Add(this.tabControl2);
            this.tabUnidad1.Location = new System.Drawing.Point(4, 22);
            this.tabUnidad1.Name = "tabUnidad1";
            this.tabUnidad1.Padding = new System.Windows.Forms.Padding(3);
            this.tabUnidad1.Size = new System.Drawing.Size(816, 419);
            this.tabUnidad1.TabIndex = 0;
            this.tabUnidad1.Text = "Unidad 1";
            this.tabUnidad1.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabActividad1);
            this.tabControl2.Location = new System.Drawing.Point(20, 18);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(782, 382);
            this.tabControl2.TabIndex = 0;
            // 
            // tabActividad1
            // 
            this.tabActividad1.Controls.Add(this.label1);
            this.tabActividad1.Controls.Add(this.tabMetodos);
            this.tabActividad1.Controls.Add(this.tituloEntrada);
            this.tabActividad1.Location = new System.Drawing.Point(4, 22);
            this.tabActividad1.Name = "tabActividad1";
            this.tabActividad1.Padding = new System.Windows.Forms.Padding(3);
            this.tabActividad1.Size = new System.Drawing.Size(774, 356);
            this.tabActividad1.TabIndex = 1;
            this.tabActividad1.Text = "Actividad 1";
            this.tabActividad1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Métodos:";
            // 
            // tabMetodos
            // 
            this.tabMetodos.Controls.Add(this.tabBiseccion);
            this.tabMetodos.Controls.Add(this.tabReglaFalsa);
            this.tabMetodos.Controls.Add(this.tabNewtonRaphson);
            this.tabMetodos.Controls.Add(this.tabSecante);
            this.tabMetodos.Location = new System.Drawing.Point(23, 168);
            this.tabMetodos.Name = "tabMetodos";
            this.tabMetodos.SelectedIndex = 0;
            this.tabMetodos.Size = new System.Drawing.Size(719, 169);
            this.tabMetodos.TabIndex = 1;
            this.tabMetodos.Click += new System.EventHandler(this.tabMetodos_Click);
            // 
            // tabBiseccion
            // 
            this.tabBiseccion.Controls.Add(this.tituloSalida);
            this.tabBiseccion.Location = new System.Drawing.Point(4, 22);
            this.tabBiseccion.Name = "tabBiseccion";
            this.tabBiseccion.Padding = new System.Windows.Forms.Padding(3);
            this.tabBiseccion.Size = new System.Drawing.Size(711, 143);
            this.tabBiseccion.TabIndex = 0;
            this.tabBiseccion.Text = "Bisección";
            this.tabBiseccion.UseVisualStyleBackColor = true;
            // 
            // tituloSalida
            // 
            this.tituloSalida.Controls.Add(this.btnObtener_Biseccion);
            this.tituloSalida.Controls.Add(this.lblIteraciones_Biseccion);
            this.tituloSalida.Controls.Add(this.lblErrorRelativo_Biseccion);
            this.tituloSalida.Controls.Add(this.lblSolucionRaiz_Biseccion);
            this.tituloSalida.Controls.Add(this.lblSolucionTitulo);
            this.tituloSalida.Controls.Add(this.lblErrorTitulo);
            this.tituloSalida.Controls.Add(this.lblIteracionesTitulo);
            this.tituloSalida.Location = new System.Drawing.Point(17, 16);
            this.tituloSalida.Name = "tituloSalida";
            this.tituloSalida.Size = new System.Drawing.Size(648, 121);
            this.tituloSalida.TabIndex = 1;
            this.tituloSalida.TabStop = false;
            this.tituloSalida.Text = "Datos de Salida:";
            // 
            // btnObtener_Biseccion
            // 
            this.btnObtener_Biseccion.Location = new System.Drawing.Point(373, 46);
            this.btnObtener_Biseccion.Name = "btnObtener_Biseccion";
            this.btnObtener_Biseccion.Size = new System.Drawing.Size(75, 23);
            this.btnObtener_Biseccion.TabIndex = 6;
            this.btnObtener_Biseccion.Text = "OBTENER";
            this.btnObtener_Biseccion.UseVisualStyleBackColor = true;
            this.btnObtener_Biseccion.Click += new System.EventHandler(this.btnObtener_Biseccion_Click);
            // 
            // lblIteraciones_Biseccion
            // 
            this.lblIteraciones_Biseccion.AutoSize = true;
            this.lblIteraciones_Biseccion.Location = new System.Drawing.Point(95, 32);
            this.lblIteraciones_Biseccion.Name = "lblIteraciones_Biseccion";
            this.lblIteraciones_Biseccion.Size = new System.Drawing.Size(13, 13);
            this.lblIteraciones_Biseccion.TabIndex = 5;
            this.lblIteraciones_Biseccion.Text = "--";
            // 
            // lblErrorRelativo_Biseccion
            // 
            this.lblErrorRelativo_Biseccion.AutoSize = true;
            this.lblErrorRelativo_Biseccion.Location = new System.Drawing.Point(114, 57);
            this.lblErrorRelativo_Biseccion.Name = "lblErrorRelativo_Biseccion";
            this.lblErrorRelativo_Biseccion.Size = new System.Drawing.Size(13, 13);
            this.lblErrorRelativo_Biseccion.TabIndex = 4;
            this.lblErrorRelativo_Biseccion.Text = "--";
            // 
            // lblSolucionRaiz_Biseccion
            // 
            this.lblSolucionRaiz_Biseccion.AutoSize = true;
            this.lblSolucionRaiz_Biseccion.Location = new System.Drawing.Point(114, 86);
            this.lblSolucionRaiz_Biseccion.Name = "lblSolucionRaiz_Biseccion";
            this.lblSolucionRaiz_Biseccion.Size = new System.Drawing.Size(13, 13);
            this.lblSolucionRaiz_Biseccion.TabIndex = 3;
            this.lblSolucionRaiz_Biseccion.Text = "--";
            // 
            // lblSolucionTitulo
            // 
            this.lblSolucionTitulo.AutoSize = true;
            this.lblSolucionTitulo.Location = new System.Drawing.Point(28, 86);
            this.lblSolucionTitulo.Name = "lblSolucionTitulo";
            this.lblSolucionTitulo.Size = new System.Drawing.Size(84, 13);
            this.lblSolucionTitulo.TabIndex = 2;
            this.lblSolucionTitulo.Text = "Solución (raíz) =";
            // 
            // lblErrorTitulo
            // 
            this.lblErrorTitulo.AutoSize = true;
            this.lblErrorTitulo.Location = new System.Drawing.Point(28, 57);
            this.lblErrorTitulo.Name = "lblErrorTitulo";
            this.lblErrorTitulo.Size = new System.Drawing.Size(80, 13);
            this.lblErrorTitulo.TabIndex = 1;
            this.lblErrorTitulo.Text = "Error Relativo =";
            // 
            // lblIteracionesTitulo
            // 
            this.lblIteracionesTitulo.AutoSize = true;
            this.lblIteracionesTitulo.Location = new System.Drawing.Point(28, 32);
            this.lblIteracionesTitulo.Name = "lblIteracionesTitulo";
            this.lblIteracionesTitulo.Size = new System.Drawing.Size(68, 13);
            this.lblIteracionesTitulo.TabIndex = 0;
            this.lblIteracionesTitulo.Text = "Iteraciones =";
            // 
            // tabReglaFalsa
            // 
            this.tabReglaFalsa.Controls.Add(this.groupBox1);
            this.tabReglaFalsa.Location = new System.Drawing.Point(4, 22);
            this.tabReglaFalsa.Name = "tabReglaFalsa";
            this.tabReglaFalsa.Padding = new System.Windows.Forms.Padding(3);
            this.tabReglaFalsa.Size = new System.Drawing.Size(711, 143);
            this.tabReglaFalsa.TabIndex = 1;
            this.tabReglaFalsa.Text = "Regla Falsa";
            this.tabReglaFalsa.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnObtener_RF);
            this.groupBox1.Controls.Add(this.lblIteraciones_RF);
            this.groupBox1.Controls.Add(this.lblErrorRelativo_RF);
            this.groupBox1.Controls.Add(this.lblSolucionRaiz_RF);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(17, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(648, 121);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de Salida:";
            // 
            // btnObtener_RF
            // 
            this.btnObtener_RF.Location = new System.Drawing.Point(373, 46);
            this.btnObtener_RF.Name = "btnObtener_RF";
            this.btnObtener_RF.Size = new System.Drawing.Size(75, 23);
            this.btnObtener_RF.TabIndex = 6;
            this.btnObtener_RF.Text = "OBTENER";
            this.btnObtener_RF.UseVisualStyleBackColor = true;
            this.btnObtener_RF.Click += new System.EventHandler(this.btnObtener_RF_Click);
            // 
            // lblIteraciones_RF
            // 
            this.lblIteraciones_RF.AutoSize = true;
            this.lblIteraciones_RF.Location = new System.Drawing.Point(95, 32);
            this.lblIteraciones_RF.Name = "lblIteraciones_RF";
            this.lblIteraciones_RF.Size = new System.Drawing.Size(13, 13);
            this.lblIteraciones_RF.TabIndex = 5;
            this.lblIteraciones_RF.Text = "--";
            // 
            // lblErrorRelativo_RF
            // 
            this.lblErrorRelativo_RF.AutoSize = true;
            this.lblErrorRelativo_RF.Location = new System.Drawing.Point(114, 57);
            this.lblErrorRelativo_RF.Name = "lblErrorRelativo_RF";
            this.lblErrorRelativo_RF.Size = new System.Drawing.Size(13, 13);
            this.lblErrorRelativo_RF.TabIndex = 4;
            this.lblErrorRelativo_RF.Text = "--";
            // 
            // lblSolucionRaiz_RF
            // 
            this.lblSolucionRaiz_RF.AutoSize = true;
            this.lblSolucionRaiz_RF.Location = new System.Drawing.Point(114, 86);
            this.lblSolucionRaiz_RF.Name = "lblSolucionRaiz_RF";
            this.lblSolucionRaiz_RF.Size = new System.Drawing.Size(13, 13);
            this.lblSolucionRaiz_RF.TabIndex = 3;
            this.lblSolucionRaiz_RF.Text = "--";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Solución (raíz) =";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Error Relativo =";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Iteraciones =";
            // 
            // tabNewtonRaphson
            // 
            this.tabNewtonRaphson.Controls.Add(this.groupBox2);
            this.tabNewtonRaphson.Location = new System.Drawing.Point(4, 22);
            this.tabNewtonRaphson.Name = "tabNewtonRaphson";
            this.tabNewtonRaphson.Size = new System.Drawing.Size(711, 143);
            this.tabNewtonRaphson.TabIndex = 2;
            this.tabNewtonRaphson.Text = "Newton-Raphson";
            this.tabNewtonRaphson.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnObtener_NR);
            this.groupBox2.Controls.Add(this.lblIteraciones_NR);
            this.groupBox2.Controls.Add(this.lblErrorRelativo_NR);
            this.groupBox2.Controls.Add(this.lblSolucionRaiz_NR);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Location = new System.Drawing.Point(17, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(648, 121);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos de Salida:";
            // 
            // btnObtener_NR
            // 
            this.btnObtener_NR.Location = new System.Drawing.Point(373, 46);
            this.btnObtener_NR.Name = "btnObtener_NR";
            this.btnObtener_NR.Size = new System.Drawing.Size(75, 23);
            this.btnObtener_NR.TabIndex = 6;
            this.btnObtener_NR.Text = "OBTENER";
            this.btnObtener_NR.UseVisualStyleBackColor = true;
            this.btnObtener_NR.Click += new System.EventHandler(this.btnObtener_NR_Click);
            // 
            // lblIteraciones_NR
            // 
            this.lblIteraciones_NR.AutoSize = true;
            this.lblIteraciones_NR.Location = new System.Drawing.Point(95, 32);
            this.lblIteraciones_NR.Name = "lblIteraciones_NR";
            this.lblIteraciones_NR.Size = new System.Drawing.Size(13, 13);
            this.lblIteraciones_NR.TabIndex = 5;
            this.lblIteraciones_NR.Text = "--";
            // 
            // lblErrorRelativo_NR
            // 
            this.lblErrorRelativo_NR.AutoSize = true;
            this.lblErrorRelativo_NR.Location = new System.Drawing.Point(114, 57);
            this.lblErrorRelativo_NR.Name = "lblErrorRelativo_NR";
            this.lblErrorRelativo_NR.Size = new System.Drawing.Size(13, 13);
            this.lblErrorRelativo_NR.TabIndex = 4;
            this.lblErrorRelativo_NR.Text = "--";
            // 
            // lblSolucionRaiz_NR
            // 
            this.lblSolucionRaiz_NR.AutoSize = true;
            this.lblSolucionRaiz_NR.Location = new System.Drawing.Point(114, 86);
            this.lblSolucionRaiz_NR.Name = "lblSolucionRaiz_NR";
            this.lblSolucionRaiz_NR.Size = new System.Drawing.Size(13, 13);
            this.lblSolucionRaiz_NR.TabIndex = 3;
            this.lblSolucionRaiz_NR.Text = "--";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(28, 86);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Solución (raíz) =";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(28, 57);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Error Relativo =";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(28, 32);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Iteraciones =";
            // 
            // tabSecante
            // 
            this.tabSecante.Controls.Add(this.groupBox3);
            this.tabSecante.Location = new System.Drawing.Point(4, 22);
            this.tabSecante.Name = "tabSecante";
            this.tabSecante.Size = new System.Drawing.Size(711, 143);
            this.tabSecante.TabIndex = 3;
            this.tabSecante.Text = "Secante";
            this.tabSecante.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnObtener_Secante);
            this.groupBox3.Controls.Add(this.lblIteraciones_Secante);
            this.groupBox3.Controls.Add(this.lblErrorRelativo_Secante);
            this.groupBox3.Controls.Add(this.lblSolucionRaiz_Secante);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Location = new System.Drawing.Point(17, 16);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(648, 121);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos de Salida:";
            // 
            // btnObtener_Secante
            // 
            this.btnObtener_Secante.Location = new System.Drawing.Point(373, 46);
            this.btnObtener_Secante.Name = "btnObtener_Secante";
            this.btnObtener_Secante.Size = new System.Drawing.Size(75, 23);
            this.btnObtener_Secante.TabIndex = 6;
            this.btnObtener_Secante.Text = "OBTENER";
            this.btnObtener_Secante.UseVisualStyleBackColor = true;
            this.btnObtener_Secante.Click += new System.EventHandler(this.btnObtener_Secante_Click);
            // 
            // lblIteraciones_Secante
            // 
            this.lblIteraciones_Secante.AutoSize = true;
            this.lblIteraciones_Secante.Location = new System.Drawing.Point(95, 32);
            this.lblIteraciones_Secante.Name = "lblIteraciones_Secante";
            this.lblIteraciones_Secante.Size = new System.Drawing.Size(13, 13);
            this.lblIteraciones_Secante.TabIndex = 5;
            this.lblIteraciones_Secante.Text = "--";
            // 
            // lblErrorRelativo_Secante
            // 
            this.lblErrorRelativo_Secante.AutoSize = true;
            this.lblErrorRelativo_Secante.Location = new System.Drawing.Point(114, 57);
            this.lblErrorRelativo_Secante.Name = "lblErrorRelativo_Secante";
            this.lblErrorRelativo_Secante.Size = new System.Drawing.Size(13, 13);
            this.lblErrorRelativo_Secante.TabIndex = 4;
            this.lblErrorRelativo_Secante.Text = "--";
            // 
            // lblSolucionRaiz_Secante
            // 
            this.lblSolucionRaiz_Secante.AutoSize = true;
            this.lblSolucionRaiz_Secante.Location = new System.Drawing.Point(114, 86);
            this.lblSolucionRaiz_Secante.Name = "lblSolucionRaiz_Secante";
            this.lblSolucionRaiz_Secante.Size = new System.Drawing.Size(13, 13);
            this.lblSolucionRaiz_Secante.TabIndex = 3;
            this.lblSolucionRaiz_Secante.Text = "--";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(28, 86);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(84, 13);
            this.label17.TabIndex = 2;
            this.label17.Text = "Solución (raíz) =";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(28, 57);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(80, 13);
            this.label18.TabIndex = 1;
            this.label18.Text = "Error Relativo =";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(28, 32);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(68, 13);
            this.label19.TabIndex = 0;
            this.label19.Text = "Iteraciones =";
            // 
            // tituloEntrada
            // 
            this.tituloEntrada.Controls.Add(this.lblPuntoInicial);
            this.tituloEntrada.Controls.Add(this.tbxPuntoInicial);
            this.tituloEntrada.Controls.Add(this.tbxLD);
            this.tituloEntrada.Controls.Add(this.tbxLI);
            this.tituloEntrada.Controls.Add(this.tbxMaxIteraciones);
            this.tituloEntrada.Controls.Add(this.tbxTolerancia);
            this.tituloEntrada.Controls.Add(this.tbxFuncion);
            this.tituloEntrada.Controls.Add(this.lblLD);
            this.tituloEntrada.Controls.Add(this.lblLI);
            this.tituloEntrada.Controls.Add(this.lblMaxIteraciones);
            this.tituloEntrada.Controls.Add(this.lblTolerancia);
            this.tituloEntrada.Controls.Add(this.lblFuncion);
            this.tituloEntrada.Location = new System.Drawing.Point(23, 21);
            this.tituloEntrada.Name = "tituloEntrada";
            this.tituloEntrada.Size = new System.Drawing.Size(719, 119);
            this.tituloEntrada.TabIndex = 0;
            this.tituloEntrada.TabStop = false;
            this.tituloEntrada.Text = "Datos de Entrada:";
            // 
            // lblPuntoInicial
            // 
            this.lblPuntoInicial.AutoSize = true;
            this.lblPuntoInicial.Location = new System.Drawing.Point(340, 86);
            this.lblPuntoInicial.Name = "lblPuntoInicial";
            this.lblPuntoInicial.Size = new System.Drawing.Size(27, 13);
            this.lblPuntoInicial.TabIndex = 11;
            this.lblPuntoInicial.Text = "Xini:";
            this.lblPuntoInicial.Visible = false;
            // 
            // tbxPuntoInicial
            // 
            this.tbxPuntoInicial.Location = new System.Drawing.Point(405, 83);
            this.tbxPuntoInicial.Name = "tbxPuntoInicial";
            this.tbxPuntoInicial.Size = new System.Drawing.Size(100, 20);
            this.tbxPuntoInicial.TabIndex = 10;
            this.tbxPuntoInicial.Visible = false;
            // 
            // tbxLD
            // 
            this.tbxLD.Location = new System.Drawing.Point(405, 57);
            this.tbxLD.Name = "tbxLD";
            this.tbxLD.Size = new System.Drawing.Size(100, 20);
            this.tbxLD.TabIndex = 9;
            // 
            // tbxLI
            // 
            this.tbxLI.Location = new System.Drawing.Point(405, 29);
            this.tbxLI.Name = "tbxLI";
            this.tbxLI.Size = new System.Drawing.Size(100, 20);
            this.tbxLI.TabIndex = 8;
            // 
            // tbxMaxIteraciones
            // 
            this.tbxMaxIteraciones.Location = new System.Drawing.Point(121, 83);
            this.tbxMaxIteraciones.Name = "tbxMaxIteraciones";
            this.tbxMaxIteraciones.Size = new System.Drawing.Size(100, 20);
            this.tbxMaxIteraciones.TabIndex = 7;
            // 
            // tbxTolerancia
            // 
            this.tbxTolerancia.Location = new System.Drawing.Point(121, 58);
            this.tbxTolerancia.Name = "tbxTolerancia";
            this.tbxTolerancia.Size = new System.Drawing.Size(100, 20);
            this.tbxTolerancia.TabIndex = 6;
            // 
            // tbxFuncion
            // 
            this.tbxFuncion.Location = new System.Drawing.Point(121, 32);
            this.tbxFuncion.Name = "tbxFuncion";
            this.tbxFuncion.Size = new System.Drawing.Size(100, 20);
            this.tbxFuncion.TabIndex = 5;
            // 
            // lblLD
            // 
            this.lblLD.AutoSize = true;
            this.lblLD.Location = new System.Drawing.Point(340, 57);
            this.lblLD.Name = "lblLD";
            this.lblLD.Size = new System.Drawing.Size(30, 13);
            this.lblLD.TabIndex = 4;
            this.lblLD.Text = "L.D.:";
            // 
            // lblLI
            // 
            this.lblLI.AutoSize = true;
            this.lblLI.Location = new System.Drawing.Point(340, 32);
            this.lblLI.Name = "lblLI";
            this.lblLI.Size = new System.Drawing.Size(25, 13);
            this.lblLI.TabIndex = 3;
            this.lblLI.Text = "L.I.:";
            // 
            // lblMaxIteraciones
            // 
            this.lblMaxIteraciones.AutoSize = true;
            this.lblMaxIteraciones.Location = new System.Drawing.Point(28, 86);
            this.lblMaxIteraciones.Name = "lblMaxIteraciones";
            this.lblMaxIteraciones.Size = new System.Drawing.Size(88, 13);
            this.lblMaxIteraciones.TabIndex = 2;
            this.lblMaxIteraciones.Text = "Máx. Iteraciones:";
            // 
            // lblTolerancia
            // 
            this.lblTolerancia.AutoSize = true;
            this.lblTolerancia.Location = new System.Drawing.Point(28, 57);
            this.lblTolerancia.Name = "lblTolerancia";
            this.lblTolerancia.Size = new System.Drawing.Size(60, 13);
            this.lblTolerancia.TabIndex = 1;
            this.lblTolerancia.Text = "Tolerancia:";
            // 
            // lblFuncion
            // 
            this.lblFuncion.AutoSize = true;
            this.lblFuncion.Location = new System.Drawing.Point(28, 32);
            this.lblFuncion.Name = "lblFuncion";
            this.lblFuncion.Size = new System.Drawing.Size(24, 13);
            this.lblFuncion.TabIndex = 0;
            this.lblFuncion.Text = "f(x):";
            // 
            // tabUnidad2
            // 
            this.tabUnidad2.Location = new System.Drawing.Point(4, 22);
            this.tabUnidad2.Name = "tabUnidad2";
            this.tabUnidad2.Padding = new System.Windows.Forms.Padding(3);
            this.tabUnidad2.Size = new System.Drawing.Size(816, 419);
            this.tabUnidad2.TabIndex = 1;
            this.tabUnidad2.Text = "Unidad 2";
            this.tabUnidad2.UseVisualStyleBackColor = true;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 459);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormPrincipal";
            this.Text = "Métodos Numéricos";
            this.tabControl1.ResumeLayout(false);
            this.tabUnidad1.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabActividad1.ResumeLayout(false);
            this.tabActividad1.PerformLayout();
            this.tabMetodos.ResumeLayout(false);
            this.tabBiseccion.ResumeLayout(false);
            this.tituloSalida.ResumeLayout(false);
            this.tituloSalida.PerformLayout();
            this.tabReglaFalsa.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabNewtonRaphson.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabSecante.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tituloEntrada.ResumeLayout(false);
            this.tituloEntrada.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabUnidad1;
        private System.Windows.Forms.TabPage tabUnidad2;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabActividad1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabMetodos;
        private System.Windows.Forms.TabPage tabBiseccion;
        private System.Windows.Forms.TabPage tabReglaFalsa;
        private System.Windows.Forms.GroupBox tituloEntrada;
        private System.Windows.Forms.GroupBox tituloSalida;
        private System.Windows.Forms.Button btnObtener_Biseccion;
        private System.Windows.Forms.Label lblIteraciones_Biseccion;
        private System.Windows.Forms.Label lblErrorRelativo_Biseccion;
        private System.Windows.Forms.Label lblSolucionRaiz_Biseccion;
        private System.Windows.Forms.Label lblSolucionTitulo;
        private System.Windows.Forms.Label lblErrorTitulo;
        private System.Windows.Forms.Label lblIteracionesTitulo;
        private System.Windows.Forms.TabPage tabNewtonRaphson;
        private System.Windows.Forms.TabPage tabSecante;
        private System.Windows.Forms.TextBox tbxLD;
        private System.Windows.Forms.TextBox tbxLI;
        private System.Windows.Forms.TextBox tbxMaxIteraciones;
        private System.Windows.Forms.TextBox tbxTolerancia;
        private System.Windows.Forms.TextBox tbxFuncion;
        private System.Windows.Forms.Label lblLD;
        private System.Windows.Forms.Label lblLI;
        private System.Windows.Forms.Label lblMaxIteraciones;
        private System.Windows.Forms.Label lblTolerancia;
        private System.Windows.Forms.Label lblFuncion;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnObtener_RF;
        private System.Windows.Forms.Label lblIteraciones_RF;
        private System.Windows.Forms.Label lblErrorRelativo_RF;
        private System.Windows.Forms.Label lblSolucionRaiz_RF;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnObtener_NR;
        private System.Windows.Forms.Label lblIteraciones_NR;
        private System.Windows.Forms.Label lblErrorRelativo_NR;
        private System.Windows.Forms.Label lblSolucionRaiz_NR;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnObtener_Secante;
        private System.Windows.Forms.Label lblIteraciones_Secante;
        private System.Windows.Forms.Label lblErrorRelativo_Secante;
        private System.Windows.Forms.Label lblSolucionRaiz_Secante;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lblPuntoInicial;
        private System.Windows.Forms.TextBox tbxPuntoInicial;
    }
}

