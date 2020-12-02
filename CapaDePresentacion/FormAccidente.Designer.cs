
namespace CapaDePresentacion
{
    partial class FormAccidente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.cmbDiasIncapacidad = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbIncapacidad = new System.Windows.Forms.ComboBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbMecanismo = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbAgente = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbParteAfectada = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbLesion = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.txtSitio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.cmbDiaE = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cmbMesE = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbAnioE = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbGravedad = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigoAccidente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(506, 49);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(132, 20);
            this.txtCedula.TabIndex = 97;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(325, 53);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(157, 16);
            this.label17.TabIndex = 96;
            this.label17.Text = "Cedula del empleado";
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(535, 622);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(164, 37);
            this.btnVolver.TabIndex = 94;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnInsertar
            // 
            this.btnInsertar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertar.Location = new System.Drawing.Point(240, 622);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(164, 37);
            this.btnInsertar.TabIndex = 93;
            this.btnInsertar.Text = "Insertar Accidente";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(87, 572);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(152, 16);
            this.label16.TabIndex = 92;
            this.label16.Text = "Dias de incapacidad";
            // 
            // cmbDiasIncapacidad
            // 
            this.cmbDiasIncapacidad.FormattingEnabled = true;
            this.cmbDiasIncapacidad.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63",
            "64",
            "65",
            "66",
            "67",
            "68",
            "69",
            "70",
            "71",
            "72",
            "73",
            "74",
            "75",
            "76",
            "77",
            "78",
            "79",
            "80",
            "81",
            "82",
            "83",
            "84",
            "85",
            "86",
            "87",
            "88",
            "89",
            "90",
            "91",
            "92",
            "93",
            "94",
            "95",
            "96",
            "97",
            "98",
            "99",
            "100",
            ""});
            this.cmbDiasIncapacidad.Location = new System.Drawing.Point(264, 567);
            this.cmbDiasIncapacidad.Name = "cmbDiasIncapacidad";
            this.cmbDiasIncapacidad.Size = new System.Drawing.Size(80, 21);
            this.cmbDiasIncapacidad.TabIndex = 91;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(87, 524);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 16);
            this.label12.TabIndex = 90;
            this.label12.Text = "Incapacidad";
            // 
            // cmbIncapacidad
            // 
            this.cmbIncapacidad.FormattingEnabled = true;
            this.cmbIncapacidad.Items.AddRange(new object[] {
            "Si",
            "No"});
            this.cmbIncapacidad.Location = new System.Drawing.Point(200, 519);
            this.cmbIncapacidad.Name = "cmbIncapacidad";
            this.cmbIncapacidad.Size = new System.Drawing.Size(175, 21);
            this.cmbIncapacidad.TabIndex = 89;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(305, 472);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(394, 20);
            this.txtDescripcion.TabIndex = 88;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(87, 476);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(189, 16);
            this.label11.TabIndex = 87;
            this.label11.Text = "Descripcion del accidente";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(87, 427);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 16);
            this.label10.TabIndex = 86;
            this.label10.Text = "Mecanismo";
            // 
            // cmbMecanismo
            // 
            this.cmbMecanismo.FormattingEnabled = true;
            this.cmbMecanismo.Items.AddRange(new object[] {
            "Atrapamientos",
            "Caidas de objetos",
            "Caidas de personas",
            "Exposicion de electricidad"});
            this.cmbMecanismo.Location = new System.Drawing.Point(187, 422);
            this.cmbMecanismo.Name = "cmbMecanismo";
            this.cmbMecanismo.Size = new System.Drawing.Size(175, 21);
            this.cmbMecanismo.TabIndex = 85;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(87, 386);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 16);
            this.label9.TabIndex = 84;
            this.label9.Text = "Agente";
            // 
            // cmbAgente
            // 
            this.cmbAgente.FormattingEnabled = true;
            this.cmbAgente.Items.AddRange(new object[] {
            "No clasificado",
            "Ambiente del trabajo",
            "Animales",
            "Aparatos",
            "Caidas de personas",
            "Herramientas",
            "Maquinarias y/o equipos"});
            this.cmbAgente.Location = new System.Drawing.Point(169, 381);
            this.cmbAgente.Name = "cmbAgente";
            this.cmbAgente.Size = new System.Drawing.Size(175, 21);
            this.cmbAgente.TabIndex = 83;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(87, 340);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(188, 16);
            this.label8.TabIndex = 82;
            this.label8.Text = "Parte del cuerpo afectada";
            // 
            // cmbParteAfectada
            // 
            this.cmbParteAfectada.FormattingEnabled = true;
            this.cmbParteAfectada.Items.AddRange(new object[] {
            "Abdomen",
            "Cabeza",
            "Cara",
            "Cuello",
            "Lesiones generales",
            "manos",
            "miembros inferiores",
            "ojos",
            "pies"});
            this.cmbParteAfectada.Location = new System.Drawing.Point(284, 335);
            this.cmbParteAfectada.Name = "cmbParteAfectada";
            this.cmbParteAfectada.Size = new System.Drawing.Size(175, 21);
            this.cmbParteAfectada.TabIndex = 81;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(84, 295);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 16);
            this.label7.TabIndex = 80;
            this.label7.Text = "Lesion del accidente";
            // 
            // cmbLesion
            // 
            this.cmbLesion.FormattingEnabled = true;
            this.cmbLesion.Items.AddRange(new object[] {
            "Amputacion",
            "Aplastamiento",
            "Asfixia",
            "Conmocion",
            "Efecto de electricidad",
            "Efecto del clima",
            "Envenenaniento",
            "Esguince",
            "Fractura",
            "Golpe",
            "Herida",
            "Intoxicacion",
            "Quemadura",
            "Salpicadura",
            "Torcedura",
            "Trauma"});
            this.cmbLesion.Location = new System.Drawing.Point(284, 290);
            this.cmbLesion.Name = "cmbLesion";
            this.cmbLesion.Size = new System.Drawing.Size(155, 21);
            this.cmbLesion.TabIndex = 79;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(84, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 16);
            this.label5.TabIndex = 78;
            this.label5.Text = "Tipo de accidente";
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "Deportivo",
            "Propios del trabajo",
            "Recreativo o Cultural",
            "Transito",
            "Violencia"});
            this.cmbTipo.Location = new System.Drawing.Point(229, 244);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(175, 21);
            this.cmbTipo.TabIndex = 77;
            // 
            // txtSitio
            // 
            this.txtSitio.Location = new System.Drawing.Point(229, 200);
            this.txtSitio.Name = "txtSitio";
            this.txtSitio.Size = new System.Drawing.Size(394, 20);
            this.txtSitio.TabIndex = 76;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(84, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 16);
            this.label4.TabIndex = 75;
            this.label4.Text = "Sitio del accidente";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(397, 132);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(32, 16);
            this.label14.TabIndex = 74;
            this.label14.Text = "Dia";
            // 
            // cmbDiaE
            // 
            this.cmbDiaE.FormattingEnabled = true;
            this.cmbDiaE.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30"});
            this.cmbDiaE.Location = new System.Drawing.Point(381, 151);
            this.cmbDiaE.Name = "cmbDiaE";
            this.cmbDiaE.Size = new System.Drawing.Size(70, 21);
            this.cmbDiaE.TabIndex = 73;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(325, 132);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(37, 16);
            this.label15.TabIndex = 72;
            this.label15.Text = "Mes";
            // 
            // cmbMesE
            // 
            this.cmbMesE.FormattingEnabled = true;
            this.cmbMesE.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cmbMesE.Location = new System.Drawing.Point(305, 151);
            this.cmbMesE.Name = "cmbMesE";
            this.cmbMesE.Size = new System.Drawing.Size(70, 21);
            this.cmbMesE.TabIndex = 71;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(250, 132);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 16);
            this.label13.TabIndex = 70;
            this.label13.Text = "Año";
            // 
            // cmbAnioE
            // 
            this.cmbAnioE.FormattingEnabled = true;
            this.cmbAnioE.Items.AddRange(new object[] {
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020"});
            this.cmbAnioE.Location = new System.Drawing.Point(229, 151);
            this.cmbAnioE.Name = "cmbAnioE";
            this.cmbAnioE.Size = new System.Drawing.Size(70, 21);
            this.cmbAnioE.TabIndex = 69;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(84, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 16);
            this.label3.TabIndex = 68;
            this.label3.Text = "Fecha del evento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(84, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(175, 16);
            this.label6.TabIndex = 67;
            this.label6.Text = "Gravedad del accidente";
            // 
            // cmbGravedad
            // 
            this.cmbGravedad.FormattingEnabled = true;
            this.cmbGravedad.Items.AddRange(new object[] {
            "Accidente alta inmediata",
            "Accidente grave",
            "Accidente leve",
            "Accidente mortal",
            "Incidente"});
            this.cmbGravedad.Location = new System.Drawing.Point(284, 99);
            this.cmbGravedad.Name = "cmbGravedad";
            this.cmbGravedad.Size = new System.Drawing.Size(155, 21);
            this.cmbGravedad.TabIndex = 66;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(314, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 24);
            this.label1.TabIndex = 65;
            this.label1.Text = "Formulario de registro de accidente";
            // 
            // txtCodigoAccidente
            // 
            this.txtCodigoAccidente.Location = new System.Drawing.Point(169, 52);
            this.txtCodigoAccidente.Name = "txtCodigoAccidente";
            this.txtCodigoAccidente.Size = new System.Drawing.Size(103, 20);
            this.txtCodigoAccidente.TabIndex = 64;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(84, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 63;
            this.label2.Text = "Codigo";
            // 
            // FormAccidente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 702);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.cmbDiasIncapacidad);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cmbIncapacidad);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cmbMecanismo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbAgente);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbParteAfectada);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbLesion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.txtSitio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.cmbDiaE);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.cmbMesE);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cmbAnioE);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbGravedad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCodigoAccidente);
            this.Controls.Add(this.label2);
            this.Name = "FormAccidente";
            this.Text = "FormAccidente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cmbDiasIncapacidad;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbIncapacidad;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbMecanismo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbAgente;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbParteAfectada;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbLesion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.TextBox txtSitio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cmbDiaE;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cmbMesE;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbAnioE;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbGravedad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigoAccidente;
        private System.Windows.Forms.Label label2;
    }
}