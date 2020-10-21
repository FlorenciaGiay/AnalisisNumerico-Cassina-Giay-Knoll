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
            this.lblConverge_Biseccion = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnObtener_Biseccion = new System.Windows.Forms.Button();
            this.lblIteraciones_Biseccion = new System.Windows.Forms.Label();
            this.lblErrorRelativo_Biseccion = new System.Windows.Forms.Label();
            this.lblSolucionRaiz_Biseccion = new System.Windows.Forms.Label();
            this.lblSolucionTitulo = new System.Windows.Forms.Label();
            this.lblErrorTitulo = new System.Windows.Forms.Label();
            this.lblIteracionesTitulo = new System.Windows.Forms.Label();
            this.tabReglaFalsa = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblConverge_RF = new System.Windows.Forms.Label();
            this.lblconv = new System.Windows.Forms.Label();
            this.btnObtener_RF = new System.Windows.Forms.Button();
            this.lblIteraciones_RF = new System.Windows.Forms.Label();
            this.lblErrorRelativo_RF = new System.Windows.Forms.Label();
            this.lblSolucionRaiz_RF = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabNewtonRaphson = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblConverge_NR = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblMensaje_NR = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnObtener_NR = new System.Windows.Forms.Button();
            this.lblIteraciones_NR = new System.Windows.Forms.Label();
            this.lblErrorRelativo_NR = new System.Windows.Forms.Label();
            this.lblSolucionRaiz_NR = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tabSecante = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblConverge_Secante = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblMensaje_Secante = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnObtener_Secante = new System.Windows.Forms.Button();
            this.lblIteraciones_Secante = new System.Windows.Forms.Label();
            this.lblErrorRelativo_Secante = new System.Windows.Forms.Label();
            this.lblSolucionRaiz_Secante = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.tituloEntrada = new System.Windows.Forms.GroupBox();
            this.tbxX2 = new System.Windows.Forms.TextBox();
            this.lblX2 = new System.Windows.Forms.Label();
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
            this.panelMatriz = new System.Windows.Forms.Panel();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnGenerarMatriz = new System.Windows.Forms.Button();
            this.tbxDimension = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cbxMetodo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tabUnidad3 = new System.Windows.Forms.TabPage();
            this.lblEfectividad = new System.Windows.Forms.Label();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.lblPorcentaje = new System.Windows.Forms.Label();
            this.lblCorrelacion = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblFuncObtenida = new System.Windows.Forms.Label();
            this.btnCalcularAjuste = new System.Windows.Forms.Button();
            this.lblMetodo = new System.Windows.Forms.Label();
            this.cbxMetodoAjuste = new System.Windows.Forms.ComboBox();
            this.lblToleranciaAjuste = new System.Windows.Forms.Label();
            this.tbxToleranciaAjuste = new System.Windows.Forms.TextBox();
            this.btnBorrarTodos = new System.Windows.Forms.Button();
            this.btnBorrarUltimo = new System.Windows.Forms.Button();
            this.btnCargarPunto = new System.Windows.Forms.Button();
            this.panelPuntosIngresados = new System.Windows.Forms.Panel();
            this.lblPuntosIngresados = new System.Windows.Forms.Label();
            this.lblCargarPuntos = new System.Windows.Forms.Label();
            this.tbxPuntoY = new System.Windows.Forms.TextBox();
            this.tbxPuntoX = new System.Windows.Forms.TextBox();
            this.tbxGrado = new System.Windows.Forms.TextBox();
            this.lblGrado = new System.Windows.Forms.Label();
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
            this.tabUnidad2.SuspendLayout();
            this.tabUnidad3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabUnidad1);
            this.tabControl1.Controls.Add(this.tabUnidad2);
            this.tabControl1.Controls.Add(this.tabUnidad3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(973, 511);
            this.tabControl1.TabIndex = 0;
            // 
            // tabUnidad1
            // 
            this.tabUnidad1.Controls.Add(this.tabControl2);
            this.tabUnidad1.Location = new System.Drawing.Point(4, 22);
            this.tabUnidad1.Name = "tabUnidad1";
            this.tabUnidad1.Padding = new System.Windows.Forms.Padding(3);
            this.tabUnidad1.Size = new System.Drawing.Size(965, 485);
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
            this.tituloSalida.Controls.Add(this.lblConverge_Biseccion);
            this.tituloSalida.Controls.Add(this.label3);
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
            // lblConverge_Biseccion
            // 
            this.lblConverge_Biseccion.AutoSize = true;
            this.lblConverge_Biseccion.Location = new System.Drawing.Point(390, 86);
            this.lblConverge_Biseccion.Name = "lblConverge_Biseccion";
            this.lblConverge_Biseccion.Size = new System.Drawing.Size(13, 13);
            this.lblConverge_Biseccion.TabIndex = 8;
            this.lblConverge_Biseccion.Text = "--";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(322, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Converge =";
            // 
            // btnObtener_Biseccion
            // 
            this.btnObtener_Biseccion.Location = new System.Drawing.Point(528, 47);
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
            this.groupBox1.Controls.Add(this.lblConverge_RF);
            this.groupBox1.Controls.Add(this.lblconv);
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
            // lblConverge_RF
            // 
            this.lblConverge_RF.AutoSize = true;
            this.lblConverge_RF.Location = new System.Drawing.Point(387, 87);
            this.lblConverge_RF.Name = "lblConverge_RF";
            this.lblConverge_RF.Size = new System.Drawing.Size(13, 13);
            this.lblConverge_RF.TabIndex = 10;
            this.lblConverge_RF.Text = "--";
            // 
            // lblconv
            // 
            this.lblconv.AutoSize = true;
            this.lblconv.Location = new System.Drawing.Point(319, 86);
            this.lblconv.Name = "lblconv";
            this.lblconv.Size = new System.Drawing.Size(62, 13);
            this.lblconv.TabIndex = 9;
            this.lblconv.Text = "Converge =";
            // 
            // btnObtener_RF
            // 
            this.btnObtener_RF.Location = new System.Drawing.Point(528, 47);
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
            this.groupBox2.Controls.Add(this.lblConverge_NR);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.lblMensaje_NR);
            this.groupBox2.Controls.Add(this.label2);
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
            // lblConverge_NR
            // 
            this.lblConverge_NR.AutoSize = true;
            this.lblConverge_NR.Location = new System.Drawing.Point(399, 87);
            this.lblConverge_NR.Name = "lblConverge_NR";
            this.lblConverge_NR.Size = new System.Drawing.Size(13, 13);
            this.lblConverge_NR.TabIndex = 12;
            this.lblConverge_NR.Text = "--";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(331, 86);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Converge =";
            // 
            // lblMensaje_NR
            // 
            this.lblMensaje_NR.AutoSize = true;
            this.lblMensaje_NR.Location = new System.Drawing.Point(225, 32);
            this.lblMensaje_NR.Name = "lblMensaje_NR";
            this.lblMensaje_NR.Size = new System.Drawing.Size(13, 13);
            this.lblMensaje_NR.TabIndex = 8;
            this.lblMensaje_NR.Text = "--";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Mensaje: ";
            // 
            // btnObtener_NR
            // 
            this.btnObtener_NR.Location = new System.Drawing.Point(528, 47);
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
            this.groupBox3.Controls.Add(this.lblConverge_Secante);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.lblMensaje_Secante);
            this.groupBox3.Controls.Add(this.label4);
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
            // lblConverge_Secante
            // 
            this.lblConverge_Secante.AutoSize = true;
            this.lblConverge_Secante.Location = new System.Drawing.Point(404, 87);
            this.lblConverge_Secante.Name = "lblConverge_Secante";
            this.lblConverge_Secante.Size = new System.Drawing.Size(13, 13);
            this.lblConverge_Secante.TabIndex = 12;
            this.lblConverge_Secante.Text = "--";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(336, 86);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Converge =";
            // 
            // lblMensaje_Secante
            // 
            this.lblMensaje_Secante.AutoSize = true;
            this.lblMensaje_Secante.Location = new System.Drawing.Point(225, 32);
            this.lblMensaje_Secante.Name = "lblMensaje_Secante";
            this.lblMensaje_Secante.Size = new System.Drawing.Size(13, 13);
            this.lblMensaje_Secante.TabIndex = 10;
            this.lblMensaje_Secante.Text = "--";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(166, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Mensaje: ";
            // 
            // btnObtener_Secante
            // 
            this.btnObtener_Secante.Location = new System.Drawing.Point(528, 47);
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
            this.tituloEntrada.Controls.Add(this.tbxX2);
            this.tituloEntrada.Controls.Add(this.lblX2);
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
            // tbxX2
            // 
            this.tbxX2.Location = new System.Drawing.Point(604, 83);
            this.tbxX2.Name = "tbxX2";
            this.tbxX2.Size = new System.Drawing.Size(100, 20);
            this.tbxX2.TabIndex = 13;
            this.tbxX2.Visible = false;
            // 
            // lblX2
            // 
            this.lblX2.AutoSize = true;
            this.lblX2.Location = new System.Drawing.Point(533, 86);
            this.lblX2.Name = "lblX2";
            this.lblX2.Size = new System.Drawing.Size(36, 13);
            this.lblX2.TabIndex = 12;
            this.lblX2.Text = "Xini2: ";
            this.lblX2.Visible = false;
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
            this.tbxFuncion.Size = new System.Drawing.Size(140, 20);
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
            this.tabUnidad2.Controls.Add(this.panelMatriz);
            this.tabUnidad2.Controls.Add(this.btnCalcular);
            this.tabUnidad2.Controls.Add(this.btnGenerarMatriz);
            this.tabUnidad2.Controls.Add(this.tbxDimension);
            this.tabUnidad2.Controls.Add(this.label14);
            this.tabUnidad2.Controls.Add(this.cbxMetodo);
            this.tabUnidad2.Controls.Add(this.label8);
            this.tabUnidad2.Location = new System.Drawing.Point(4, 22);
            this.tabUnidad2.Name = "tabUnidad2";
            this.tabUnidad2.Padding = new System.Windows.Forms.Padding(3);
            this.tabUnidad2.Size = new System.Drawing.Size(965, 485);
            this.tabUnidad2.TabIndex = 1;
            this.tabUnidad2.Text = "Unidad 2";
            this.tabUnidad2.UseVisualStyleBackColor = true;
            // 
            // panelMatriz
            // 
            this.panelMatriz.AutoSize = true;
            this.panelMatriz.Location = new System.Drawing.Point(45, 60);
            this.panelMatriz.Name = "panelMatriz";
            this.panelMatriz.Size = new System.Drawing.Size(775, 408);
            this.panelMatriz.TabIndex = 7;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(854, 15);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(93, 40);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "CALCULAR";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnGenerarMatriz
            // 
            this.btnGenerarMatriz.Location = new System.Drawing.Point(467, 15);
            this.btnGenerarMatriz.Name = "btnGenerarMatriz";
            this.btnGenerarMatriz.Size = new System.Drawing.Size(138, 23);
            this.btnGenerarMatriz.TabIndex = 5;
            this.btnGenerarMatriz.Text = "GENERAR MATRIZ";
            this.btnGenerarMatriz.UseVisualStyleBackColor = true;
            this.btnGenerarMatriz.Click += new System.EventHandler(this.btnGenerarMatriz_Click);
            // 
            // tbxDimension
            // 
            this.tbxDimension.Location = new System.Drawing.Point(325, 16);
            this.tbxDimension.Name = "tbxDimension";
            this.tbxDimension.Size = new System.Drawing.Size(100, 20);
            this.tbxDimension.TabIndex = 4;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(260, 20);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 13);
            this.label14.TabIndex = 3;
            this.label14.Text = "Dimensión:";
            // 
            // cbxMetodo
            // 
            this.cbxMetodo.FormattingEnabled = true;
            this.cbxMetodo.Items.AddRange(new object[] {
            "Gauss Jordan",
            "Gauss Seidel"});
            this.cbxMetodo.Location = new System.Drawing.Point(79, 15);
            this.cbxMetodo.Name = "cbxMetodo";
            this.cbxMetodo.Size = new System.Drawing.Size(121, 21);
            this.cbxMetodo.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Método:";
            // 
            // tabUnidad3
            // 
            this.tabUnidad3.Controls.Add(this.lblGrado);
            this.tabUnidad3.Controls.Add(this.tbxGrado);
            this.tabUnidad3.Controls.Add(this.lblEfectividad);
            this.tabUnidad3.Controls.Add(this.lblMensaje);
            this.tabUnidad3.Controls.Add(this.lblPorcentaje);
            this.tabUnidad3.Controls.Add(this.lblCorrelacion);
            this.tabUnidad3.Controls.Add(this.lblResultado);
            this.tabUnidad3.Controls.Add(this.lblFuncObtenida);
            this.tabUnidad3.Controls.Add(this.btnCalcularAjuste);
            this.tabUnidad3.Controls.Add(this.lblMetodo);
            this.tabUnidad3.Controls.Add(this.cbxMetodoAjuste);
            this.tabUnidad3.Controls.Add(this.lblToleranciaAjuste);
            this.tabUnidad3.Controls.Add(this.tbxToleranciaAjuste);
            this.tabUnidad3.Controls.Add(this.btnBorrarTodos);
            this.tabUnidad3.Controls.Add(this.btnBorrarUltimo);
            this.tabUnidad3.Controls.Add(this.btnCargarPunto);
            this.tabUnidad3.Controls.Add(this.panelPuntosIngresados);
            this.tabUnidad3.Controls.Add(this.lblPuntosIngresados);
            this.tabUnidad3.Controls.Add(this.lblCargarPuntos);
            this.tabUnidad3.Controls.Add(this.tbxPuntoY);
            this.tabUnidad3.Controls.Add(this.tbxPuntoX);
            this.tabUnidad3.Location = new System.Drawing.Point(4, 22);
            this.tabUnidad3.Name = "tabUnidad3";
            this.tabUnidad3.Size = new System.Drawing.Size(965, 485);
            this.tabUnidad3.TabIndex = 2;
            this.tabUnidad3.Text = "Unidad 3";
            this.tabUnidad3.UseVisualStyleBackColor = true;
            // 
            // lblEfectividad
            // 
            this.lblEfectividad.AutoSize = true;
            this.lblEfectividad.Location = new System.Drawing.Point(177, 304);
            this.lblEfectividad.Name = "lblEfectividad";
            this.lblEfectividad.Size = new System.Drawing.Size(13, 13);
            this.lblEfectividad.TabIndex = 19;
            this.lblEfectividad.Text = "--";
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Location = new System.Drawing.Point(47, 304);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(112, 13);
            this.lblMensaje.TabIndex = 18;
            this.lblMensaje.Text = "Efectividad del Ajuste:";
            // 
            // lblPorcentaje
            // 
            this.lblPorcentaje.AutoSize = true;
            this.lblPorcentaje.Location = new System.Drawing.Point(177, 266);
            this.lblPorcentaje.Name = "lblPorcentaje";
            this.lblPorcentaje.Size = new System.Drawing.Size(13, 13);
            this.lblPorcentaje.TabIndex = 17;
            this.lblPorcentaje.Text = "--";
            // 
            // lblCorrelacion
            // 
            this.lblCorrelacion.AutoSize = true;
            this.lblCorrelacion.Location = new System.Drawing.Point(47, 266);
            this.lblCorrelacion.Name = "lblCorrelacion";
            this.lblCorrelacion.Size = new System.Drawing.Size(91, 13);
            this.lblCorrelacion.TabIndex = 16;
            this.lblCorrelacion.Text = "Porc. Correlación:";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(177, 227);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(13, 13);
            this.lblResultado.TabIndex = 15;
            this.lblResultado.Text = "--";
            // 
            // lblFuncObtenida
            // 
            this.lblFuncObtenida.AutoSize = true;
            this.lblFuncObtenida.Location = new System.Drawing.Point(47, 227);
            this.lblFuncObtenida.Name = "lblFuncObtenida";
            this.lblFuncObtenida.Size = new System.Drawing.Size(97, 13);
            this.lblFuncObtenida.TabIndex = 14;
            this.lblFuncObtenida.Text = "Función Obtenida: ";
            // 
            // btnCalcularAjuste
            // 
            this.btnCalcularAjuste.Location = new System.Drawing.Point(325, 123);
            this.btnCalcularAjuste.Name = "btnCalcularAjuste";
            this.btnCalcularAjuste.Size = new System.Drawing.Size(106, 23);
            this.btnCalcularAjuste.TabIndex = 13;
            this.btnCalcularAjuste.Text = "CALCULAR";
            this.btnCalcularAjuste.UseVisualStyleBackColor = true;
            this.btnCalcularAjuste.Click += new System.EventHandler(this.btnCalcularAjuste_Click);
            // 
            // lblMetodo
            // 
            this.lblMetodo.AutoSize = true;
            this.lblMetodo.Location = new System.Drawing.Point(41, 148);
            this.lblMetodo.Name = "lblMetodo";
            this.lblMetodo.Size = new System.Drawing.Size(87, 13);
            this.lblMetodo.TabIndex = 12;
            this.lblMetodo.Text = "Método a utilizar:";
            // 
            // cbxMetodoAjuste
            // 
            this.cbxMetodoAjuste.FormattingEnabled = true;
            this.cbxMetodoAjuste.Items.AddRange(new object[] {
            "Regresión Lineal",
            "Regresión Polinomial",
            "Lagrange"});
            this.cbxMetodoAjuste.Location = new System.Drawing.Point(44, 172);
            this.cbxMetodoAjuste.Name = "cbxMetodoAjuste";
            this.cbxMetodoAjuste.Size = new System.Drawing.Size(121, 21);
            this.cbxMetodoAjuste.TabIndex = 11;
            this.cbxMetodoAjuste.SelectedIndexChanged += new System.EventHandler(this.cbxMetodoAjuste_SelectedIndexChanged);
            // 
            // lblToleranciaAjuste
            // 
            this.lblToleranciaAjuste.AutoSize = true;
            this.lblToleranciaAjuste.Location = new System.Drawing.Point(41, 92);
            this.lblToleranciaAjuste.Name = "lblToleranciaAjuste";
            this.lblToleranciaAjuste.Size = new System.Drawing.Size(60, 13);
            this.lblToleranciaAjuste.TabIndex = 9;
            this.lblToleranciaAjuste.Text = "Tolerancia:";
            // 
            // tbxToleranciaAjuste
            // 
            this.tbxToleranciaAjuste.Location = new System.Drawing.Point(44, 108);
            this.tbxToleranciaAjuste.Name = "tbxToleranciaAjuste";
            this.tbxToleranciaAjuste.Size = new System.Drawing.Size(52, 20);
            this.tbxToleranciaAjuste.TabIndex = 8;
            // 
            // btnBorrarTodos
            // 
            this.btnBorrarTodos.Location = new System.Drawing.Point(674, 199);
            this.btnBorrarTodos.Name = "btnBorrarTodos";
            this.btnBorrarTodos.Size = new System.Drawing.Size(106, 23);
            this.btnBorrarTodos.TabIndex = 7;
            this.btnBorrarTodos.Text = "BORRAR TODOS";
            this.btnBorrarTodos.UseVisualStyleBackColor = true;
            this.btnBorrarTodos.Click += new System.EventHandler(this.btnBorrarTodos_Click);
            // 
            // btnBorrarUltimo
            // 
            this.btnBorrarUltimo.Location = new System.Drawing.Point(674, 138);
            this.btnBorrarUltimo.Name = "btnBorrarUltimo";
            this.btnBorrarUltimo.Size = new System.Drawing.Size(106, 23);
            this.btnBorrarUltimo.TabIndex = 6;
            this.btnBorrarUltimo.Text = "BORRAR ULTIMO";
            this.btnBorrarUltimo.UseVisualStyleBackColor = true;
            this.btnBorrarUltimo.Click += new System.EventHandler(this.btnBorrarUltimo_Click);
            // 
            // btnCargarPunto
            // 
            this.btnCargarPunto.Location = new System.Drawing.Point(228, 53);
            this.btnCargarPunto.Name = "btnCargarPunto";
            this.btnCargarPunto.Size = new System.Drawing.Size(106, 23);
            this.btnCargarPunto.TabIndex = 5;
            this.btnCargarPunto.Text = "CARGAR";
            this.btnCargarPunto.UseVisualStyleBackColor = true;
            this.btnCargarPunto.Click += new System.EventHandler(this.btnCargarPunto_Click);
            // 
            // panelPuntosIngresados
            // 
            this.panelPuntosIngresados.BackColor = System.Drawing.Color.Silver;
            this.panelPuntosIngresados.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelPuntosIngresados.Location = new System.Drawing.Point(468, 49);
            this.panelPuntosIngresados.Name = "panelPuntosIngresados";
            this.panelPuntosIngresados.Size = new System.Drawing.Size(169, 303);
            this.panelPuntosIngresados.TabIndex = 4;
            // 
            // lblPuntosIngresados
            // 
            this.lblPuntosIngresados.AutoSize = true;
            this.lblPuntosIngresados.Location = new System.Drawing.Point(465, 23);
            this.lblPuntosIngresados.Name = "lblPuntosIngresados";
            this.lblPuntosIngresados.Size = new System.Drawing.Size(98, 13);
            this.lblPuntosIngresados.TabIndex = 3;
            this.lblPuntosIngresados.Text = "Puntos Ingresados:";
            // 
            // lblCargarPuntos
            // 
            this.lblCargarPuntos.AutoSize = true;
            this.lblCargarPuntos.Location = new System.Drawing.Point(41, 23);
            this.lblCargarPuntos.Name = "lblCargarPuntos";
            this.lblCargarPuntos.Size = new System.Drawing.Size(111, 13);
            this.lblCargarPuntos.TabIndex = 2;
            this.lblCargarPuntos.Text = "Ingresar Punto (X , Y):";
            // 
            // tbxPuntoY
            // 
            this.tbxPuntoY.Location = new System.Drawing.Point(129, 53);
            this.tbxPuntoY.Name = "tbxPuntoY";
            this.tbxPuntoY.Size = new System.Drawing.Size(52, 20);
            this.tbxPuntoY.TabIndex = 1;
            // 
            // tbxPuntoX
            // 
            this.tbxPuntoX.Location = new System.Drawing.Point(44, 53);
            this.tbxPuntoX.Name = "tbxPuntoX";
            this.tbxPuntoX.Size = new System.Drawing.Size(52, 20);
            this.tbxPuntoX.TabIndex = 0;
            // 
            // tbxGrado
            // 
            this.tbxGrado.Location = new System.Drawing.Point(201, 172);
            this.tbxGrado.Name = "tbxGrado";
            this.tbxGrado.Size = new System.Drawing.Size(100, 20);
            this.tbxGrado.TabIndex = 20;
            this.tbxGrado.Visible = false;
            // 
            // lblGrado
            // 
            this.lblGrado.AutoSize = true;
            this.lblGrado.Location = new System.Drawing.Point(198, 148);
            this.lblGrado.Name = "lblGrado";
            this.lblGrado.Size = new System.Drawing.Size(87, 13);
            this.lblGrado.TabIndex = 21;
            this.lblGrado.Text = "Grado Polinomio:";
            this.lblGrado.Visible = false;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 524);
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
            this.tabUnidad2.ResumeLayout(false);
            this.tabUnidad2.PerformLayout();
            this.tabUnidad3.ResumeLayout(false);
            this.tabUnidad3.PerformLayout();
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
        private System.Windows.Forms.Label lblMensaje_NR;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMensaje_Secante;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblConverge_Biseccion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblConverge_RF;
        private System.Windows.Forms.Label lblconv;
        private System.Windows.Forms.Label lblConverge_NR;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblConverge_Secante;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblX2;
        private System.Windows.Forms.TextBox tbxX2;
        private System.Windows.Forms.Button btnGenerarMatriz;
        private System.Windows.Forms.TextBox tbxDimension;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbxMetodo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Panel panelMatriz;
        private System.Windows.Forms.TabPage tabUnidad3;
        private System.Windows.Forms.Label lblCargarPuntos;
        private System.Windows.Forms.TextBox tbxPuntoY;
        private System.Windows.Forms.TextBox tbxPuntoX;
        private System.Windows.Forms.Label lblMetodo;
        private System.Windows.Forms.ComboBox cbxMetodoAjuste;
        private System.Windows.Forms.Label lblToleranciaAjuste;
        private System.Windows.Forms.TextBox tbxToleranciaAjuste;
        private System.Windows.Forms.Button btnBorrarTodos;
        private System.Windows.Forms.Button btnBorrarUltimo;
        private System.Windows.Forms.Button btnCargarPunto;
        private System.Windows.Forms.Panel panelPuntosIngresados;
        private System.Windows.Forms.Label lblPuntosIngresados;
        private System.Windows.Forms.Label lblPorcentaje;
        private System.Windows.Forms.Label lblCorrelacion;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblFuncObtenida;
        private System.Windows.Forms.Button btnCalcularAjuste;
        private System.Windows.Forms.Label lblEfectividad;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Label lblGrado;
        private System.Windows.Forms.TextBox tbxGrado;
    }
}

