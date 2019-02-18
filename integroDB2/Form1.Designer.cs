namespace integroDB2
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label iD_врачаLabel;
            System.Windows.Forms.Label фИОLabel;
            System.Windows.Forms.Label должностьLabel;
            System.Windows.Forms.Label ___кабинетаLabel;
            System.Windows.Forms.Label время_приемаLabel;
            System.Windows.Forms.Label вид_оказываемых_услугLabel;
            System.Windows.Forms.Label телефонLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label8;
            System.Windows.Forms.Label label9;
            System.Windows.Forms.Label iD_врачаLabel1;
            System.Windows.Forms.Label фИОLabel1;
            System.Windows.Forms.Label должностьLabel1;
            System.Windows.Forms.Label ___кабинетаLabel1;
            System.Windows.Forms.Label время_приемаLabel1;
            System.Windows.Forms.Label вид_оказываемых_услугLabel1;
            System.Windows.Forms.Label телефонLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.Label iD_врачаLabel2;
            System.Windows.Forms.Label фИОLabel2;
            System.Windows.Forms.Label должностьLabel2;
            System.Windows.Forms.Label ___кабинетаLabel2;
            System.Windows.Forms.Label время_приемаLabel2;
            System.Windows.Forms.Label вид_оказываемых_услугLabel2;
            System.Windows.Forms.Label телефонLabel2;
            this.стоматологияDataSet = new integroDB2.стоматологияDataSet();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDВрачаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фИОDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.должностьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кабинетаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.времяПриемаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.видОказываемыхУслугDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фотоВрачаDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.телефонDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.врачиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ФотоTB = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ТелефонTB = new System.Windows.Forms.TextBox();
            this.кабинетTB = new System.Windows.Forms.TextBox();
            this.ФИОTB = new System.Windows.Forms.TextBox();
            this.ID_врачаTB = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ФотоTB1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.ТелефонTB1 = new System.Windows.Forms.TextBox();
            this.кабинетTB1 = new System.Windows.Forms.TextBox();
            this.ФИОTB1 = new System.Windows.Forms.TextBox();
            this.ID_врачаTB1 = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.врачиTableAdapter = new integroDB2.стоматологияDataSetTableAdapters.ВрачиTableAdapter();
            this.tableAdapterManager = new integroDB2.стоматологияDataSetTableAdapters.TableAdapterManager();
            this.стоматологияDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.штатноеРасписаниеBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.штатное_расписаниеTableAdapter = new integroDB2.стоматологияDataSetTableAdapters.Штатное_расписаниеTableAdapter();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.iD_врачаTextBox = new System.Windows.Forms.TextBox();
            this.фИОTextBox = new System.Windows.Forms.TextBox();
            this.должностьTextBox = new System.Windows.Forms.TextBox();
            this.___кабинетаTextBox = new System.Windows.Forms.TextBox();
            this.время_приемаTextBox = new System.Windows.Forms.TextBox();
            this.вид_оказываемых_услугTextBox = new System.Windows.Forms.TextBox();
            this.телефонTextBox = new System.Windows.Forms.TextBox();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.bindingNavigator2 = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.button3 = new System.Windows.Forms.Button();
            this.iD_врачаTextBox1 = new System.Windows.Forms.TextBox();
            this.фИОTextBox1 = new System.Windows.Forms.TextBox();
            this.должностьTextBox1 = new System.Windows.Forms.TextBox();
            this.___кабинетаTextBox1 = new System.Windows.Forms.TextBox();
            this.время_приемаTextBox1 = new System.Windows.Forms.TextBox();
            this.вид_оказываемых_услугTextBox1 = new System.Windows.Forms.TextBox();
            this.телефонTextBox1 = new System.Windows.Forms.TextBox();
            this.ДолжностьTB = new System.Windows.Forms.ComboBox();
            this.Время_приемаTB = new System.Windows.Forms.ComboBox();
            this.Вид_оказ_услугTB = new System.Windows.Forms.ComboBox();
            this.сменаподстановкаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.смена_подстановкаTableAdapter = new integroDB2.стоматологияDataSetTableAdapters.Смена_подстановкаTableAdapter();
            this.услугиподстановкаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.услуги_подстановкаTableAdapter = new integroDB2.стоматологияDataSetTableAdapters.Услуги_подстановкаTableAdapter();
            this.ДолжностьTB1 = new System.Windows.Forms.ComboBox();
            this.Время_приемаTB1 = new System.Windows.Forms.ComboBox();
            this.Вид_оказ_услугTB1 = new System.Windows.Forms.ComboBox();
            iD_врачаLabel = new System.Windows.Forms.Label();
            фИОLabel = new System.Windows.Forms.Label();
            должностьLabel = new System.Windows.Forms.Label();
            ___кабинетаLabel = new System.Windows.Forms.Label();
            время_приемаLabel = new System.Windows.Forms.Label();
            вид_оказываемых_услугLabel = new System.Windows.Forms.Label();
            телефонLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            iD_врачаLabel1 = new System.Windows.Forms.Label();
            фИОLabel1 = new System.Windows.Forms.Label();
            должностьLabel1 = new System.Windows.Forms.Label();
            ___кабинетаLabel1 = new System.Windows.Forms.Label();
            время_приемаLabel1 = new System.Windows.Forms.Label();
            вид_оказываемых_услугLabel1 = new System.Windows.Forms.Label();
            телефонLabel1 = new System.Windows.Forms.Label();
            iD_врачаLabel2 = new System.Windows.Forms.Label();
            фИОLabel2 = new System.Windows.Forms.Label();
            должностьLabel2 = new System.Windows.Forms.Label();
            ___кабинетаLabel2 = new System.Windows.Forms.Label();
            время_приемаLabel2 = new System.Windows.Forms.Label();
            вид_оказываемых_услугLabel2 = new System.Windows.Forms.Label();
            телефонLabel2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.стоматологияDataSet)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.врачиBindingSource)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.стоматологияDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.штатноеРасписаниеBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).BeginInit();
            this.bindingNavigator2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.сменаподстановкаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.услугиподстановкаBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // iD_врачаLabel
            // 
            iD_врачаLabel.AutoSize = true;
            iD_врачаLabel.Location = new System.Drawing.Point(6, 26);
            iD_врачаLabel.Name = "iD_врачаLabel";
            iD_врачаLabel.Size = new System.Drawing.Size(53, 13);
            iD_врачаLabel.TabIndex = 0;
            iD_врачаLabel.Text = "ID врача:";
            // 
            // фИОLabel
            // 
            фИОLabel.AutoSize = true;
            фИОLabel.Location = new System.Drawing.Point(6, 52);
            фИОLabel.Name = "фИОLabel";
            фИОLabel.Size = new System.Drawing.Size(37, 13);
            фИОLabel.TabIndex = 2;
            фИОLabel.Text = "ФИО:";
            // 
            // должностьLabel
            // 
            должностьLabel.AutoSize = true;
            должностьLabel.Location = new System.Drawing.Point(6, 78);
            должностьLabel.Name = "должностьLabel";
            должностьLabel.Size = new System.Drawing.Size(68, 13);
            должностьLabel.TabIndex = 4;
            должностьLabel.Text = "Должность:";
            // 
            // ___кабинетаLabel
            // 
            ___кабинетаLabel.AutoSize = true;
            ___кабинетаLabel.Location = new System.Drawing.Point(6, 104);
            ___кабинетаLabel.Name = "___кабинетаLabel";
            ___кабинетаLabel.Size = new System.Drawing.Size(71, 13);
            ___кабинетаLabel.TabIndex = 6;
            ___кабинетаLabel.Text = "№ кабинета:";
            // 
            // время_приемаLabel
            // 
            время_приемаLabel.AutoSize = true;
            время_приемаLabel.Location = new System.Drawing.Point(6, 130);
            время_приемаLabel.Name = "время_приемаLabel";
            время_приемаLabel.Size = new System.Drawing.Size(84, 13);
            время_приемаLabel.TabIndex = 8;
            время_приемаLabel.Text = "Время приема:";
            // 
            // вид_оказываемых_услугLabel
            // 
            вид_оказываемых_услугLabel.AutoSize = true;
            вид_оказываемых_услугLabel.Location = new System.Drawing.Point(6, 156);
            вид_оказываемых_услугLabel.Name = "вид_оказываемых_услугLabel";
            вид_оказываемых_услугLabel.Size = new System.Drawing.Size(133, 13);
            вид_оказываемых_услугLabel.TabIndex = 10;
            вид_оказываемых_услугLabel.Text = "Вид оказываемых услуг:";
            // 
            // телефонLabel
            // 
            телефонLabel.AutoSize = true;
            телефонLabel.Location = new System.Drawing.Point(6, 182);
            телефонLabel.Name = "телефонLabel";
            телефонLabel.Size = new System.Drawing.Size(55, 13);
            телефонLabel.TabIndex = 12;
            телефонLabel.Text = "Телефон:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(6, 208);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(98, 13);
            label1.TabIndex = 22;
            label1.Text = "Фото врача (путь)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(6, 211);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(98, 13);
            label2.TabIndex = 39;
            label2.Text = "Фото врача (путь)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(6, 29);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(53, 13);
            label3.TabIndex = 23;
            label3.Text = "ID врача:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(6, 55);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(37, 13);
            label4.TabIndex = 24;
            label4.Text = "ФИО:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(6, 81);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(68, 13);
            label5.TabIndex = 25;
            label5.Text = "Должность:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(6, 107);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(71, 13);
            label6.TabIndex = 26;
            label6.Text = "№ кабинета:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(6, 133);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(84, 13);
            label7.TabIndex = 27;
            label7.Text = "Время приема:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(6, 159);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(133, 13);
            label8.TabIndex = 28;
            label8.Text = "Вид оказываемых услуг:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(6, 185);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(55, 13);
            label9.TabIndex = 29;
            label9.Text = "Телефон:";
            // 
            // стоматологияDataSet
            // 
            this.стоматологияDataSet.DataSetName = "стоматологияDataSet";
            this.стоматологияDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(928, 450);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl1_Selecting);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(920, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "SELECT";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDВрачаDataGridViewTextBoxColumn,
            this.фИОDataGridViewTextBoxColumn,
            this.должностьDataGridViewTextBoxColumn,
            this.кабинетаDataGridViewTextBoxColumn,
            this.времяПриемаDataGridViewTextBoxColumn,
            this.видОказываемыхУслугDataGridViewTextBoxColumn,
            this.фотоВрачаDataGridViewImageColumn,
            this.телефонDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.врачиBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(914, 418);
            this.dataGridView1.TabIndex = 0;
            // 
            // iDВрачаDataGridViewTextBoxColumn
            // 
            this.iDВрачаDataGridViewTextBoxColumn.DataPropertyName = "ID врача";
            this.iDВрачаDataGridViewTextBoxColumn.HeaderText = "ID врача";
            this.iDВрачаDataGridViewTextBoxColumn.Name = "iDВрачаDataGridViewTextBoxColumn";
            // 
            // фИОDataGridViewTextBoxColumn
            // 
            this.фИОDataGridViewTextBoxColumn.DataPropertyName = "ФИО";
            this.фИОDataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.фИОDataGridViewTextBoxColumn.Name = "фИОDataGridViewTextBoxColumn";
            // 
            // должностьDataGridViewTextBoxColumn
            // 
            this.должностьDataGridViewTextBoxColumn.DataPropertyName = "Должность";
            this.должностьDataGridViewTextBoxColumn.HeaderText = "Должность";
            this.должностьDataGridViewTextBoxColumn.Name = "должностьDataGridViewTextBoxColumn";
            // 
            // кабинетаDataGridViewTextBoxColumn
            // 
            this.кабинетаDataGridViewTextBoxColumn.DataPropertyName = "№ кабинета";
            this.кабинетаDataGridViewTextBoxColumn.HeaderText = "№ кабинета";
            this.кабинетаDataGridViewTextBoxColumn.Name = "кабинетаDataGridViewTextBoxColumn";
            // 
            // времяПриемаDataGridViewTextBoxColumn
            // 
            this.времяПриемаDataGridViewTextBoxColumn.DataPropertyName = "Время приема";
            this.времяПриемаDataGridViewTextBoxColumn.HeaderText = "Время приема";
            this.времяПриемаDataGridViewTextBoxColumn.Name = "времяПриемаDataGridViewTextBoxColumn";
            // 
            // видОказываемыхУслугDataGridViewTextBoxColumn
            // 
            this.видОказываемыхУслугDataGridViewTextBoxColumn.DataPropertyName = "Вид оказываемых услуг";
            this.видОказываемыхУслугDataGridViewTextBoxColumn.HeaderText = "Вид оказываемых услуг";
            this.видОказываемыхУслугDataGridViewTextBoxColumn.Name = "видОказываемыхУслугDataGridViewTextBoxColumn";
            // 
            // фотоВрачаDataGridViewImageColumn
            // 
            this.фотоВрачаDataGridViewImageColumn.DataPropertyName = "Фото врача";
            this.фотоВрачаDataGridViewImageColumn.HeaderText = "Фото врача";
            this.фотоВрачаDataGridViewImageColumn.Name = "фотоВрачаDataGridViewImageColumn";
            // 
            // телефонDataGridViewTextBoxColumn
            // 
            this.телефонDataGridViewTextBoxColumn.DataPropertyName = "Телефон";
            this.телефонDataGridViewTextBoxColumn.HeaderText = "Телефон";
            this.телефонDataGridViewTextBoxColumn.Name = "телефонDataGridViewTextBoxColumn";
            // 
            // врачиBindingSource
            // 
            this.врачиBindingSource.DataMember = "Врачи";
            this.врачиBindingSource.DataSource = this.стоматологияDataSet;
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(920, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "INSERT";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ФотоTB
            // 
            this.ФотоTB.Location = new System.Drawing.Point(145, 205);
            this.ФотоTB.Name = "ФотоTB";
            this.ФотоTB.Size = new System.Drawing.Size(120, 20);
            this.ФотоTB.TabIndex = 21;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(145, 247);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "INSERT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ТелефонTB
            // 
            this.ТелефонTB.Location = new System.Drawing.Point(145, 179);
            this.ТелефонTB.Name = "ТелефонTB";
            this.ТелефонTB.Size = new System.Drawing.Size(120, 20);
            this.ТелефонTB.TabIndex = 19;
            // 
            // кабинетTB
            // 
            this.кабинетTB.Location = new System.Drawing.Point(145, 101);
            this.кабинетTB.Name = "кабинетTB";
            this.кабинетTB.Size = new System.Drawing.Size(120, 20);
            this.кабинетTB.TabIndex = 16;
            // 
            // ФИОTB
            // 
            this.ФИОTB.Location = new System.Drawing.Point(145, 49);
            this.ФИОTB.Name = "ФИОTB";
            this.ФИОTB.Size = new System.Drawing.Size(120, 20);
            this.ФИОTB.TabIndex = 14;
            // 
            // ID_врачаTB
            // 
            this.ID_врачаTB.Location = new System.Drawing.Point(145, 23);
            this.ID_врачаTB.Name = "ID_врачаTB";
            this.ID_врачаTB.Size = new System.Drawing.Size(120, 20);
            this.ID_врачаTB.TabIndex = 13;
            // 
            // tabPage3
            // 
            this.tabPage3.AutoScroll = true;
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(920, 424);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "UPDATE";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(label2);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.ФотоTB1);
            this.groupBox1.Controls.Add(this.ТелефонTB1);
            this.groupBox1.Controls.Add(this.ДолжностьTB1);
            this.groupBox1.Controls.Add(this.кабинетTB1);
            this.groupBox1.Controls.Add(this.ФИОTB1);
            this.groupBox1.Controls.Add(this.Время_приемаTB1);
            this.groupBox1.Controls.Add(this.ID_врачаTB1);
            this.groupBox1.Controls.Add(this.Вид_оказ_услугTB1);
            this.groupBox1.Controls.Add(label3);
            this.groupBox1.Controls.Add(label4);
            this.groupBox1.Controls.Add(label5);
            this.groupBox1.Controls.Add(label6);
            this.groupBox1.Controls.Add(label7);
            this.groupBox1.Controls.Add(label8);
            this.groupBox1.Controls.Add(label9);
            this.groupBox1.Location = new System.Drawing.Point(328, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(291, 399);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Новые данные";
            // 
            // ФотоTB1
            // 
            this.ФотоTB1.Location = new System.Drawing.Point(145, 208);
            this.ФотоTB1.Name = "ФотоTB1";
            this.ФотоTB1.Size = new System.Drawing.Size(120, 20);
            this.ФотоTB1.TabIndex = 38;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(145, 250);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 23);
            this.button2.TabIndex = 37;
            this.button2.Text = "UPDATE";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ТелефонTB1
            // 
            this.ТелефонTB1.Location = new System.Drawing.Point(145, 182);
            this.ТелефонTB1.Name = "ТелефонTB1";
            this.ТелефонTB1.Size = new System.Drawing.Size(120, 20);
            this.ТелефонTB1.TabIndex = 36;
            // 
            // кабинетTB1
            // 
            this.кабинетTB1.Location = new System.Drawing.Point(145, 104);
            this.кабинетTB1.Name = "кабинетTB1";
            this.кабинетTB1.Size = new System.Drawing.Size(120, 20);
            this.кабинетTB1.TabIndex = 33;
            // 
            // ФИОTB1
            // 
            this.ФИОTB1.Location = new System.Drawing.Point(145, 52);
            this.ФИОTB1.Name = "ФИОTB1";
            this.ФИОTB1.Size = new System.Drawing.Size(120, 20);
            this.ФИОTB1.TabIndex = 31;
            // 
            // ID_врачаTB1
            // 
            this.ID_врачаTB1.Location = new System.Drawing.Point(145, 26);
            this.ID_врачаTB1.Name = "ID_врачаTB1";
            this.ID_врачаTB1.Size = new System.Drawing.Size(120, 20);
            this.ID_врачаTB1.TabIndex = 30;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.groupBox4);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(920, 424);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "DELETE";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // врачиTableAdapter
            // 
            this.врачиTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = integroDB2.стоматологияDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ВрачиTableAdapter = this.врачиTableAdapter;
            this.tableAdapterManager.ЖурналTableAdapter = null;
            this.tableAdapterManager.НаименованиеУслугTableAdapter = null;
            this.tableAdapterManager.Смена_подстановкаTableAdapter = null;
            this.tableAdapterManager.СписокПациентовTableAdapter = null;
            this.tableAdapterManager.Услуги_подстановкаTableAdapter = null;
            this.tableAdapterManager.Штатное_расписаниеTableAdapter = null;
            // 
            // стоматологияDataSetBindingSource
            // 
            this.стоматологияDataSetBindingSource.DataSource = this.стоматологияDataSet;
            this.стоматологияDataSetBindingSource.Position = 0;
            // 
            // штатноеРасписаниеBindingSource
            // 
            this.штатноеРасписаниеBindingSource.DataMember = "Штатное расписание";
            this.штатноеРасписаниеBindingSource.DataSource = this.стоматологияDataSet;
            // 
            // штатное_расписаниеTableAdapter
            // 
            this.штатное_расписаниеTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bindingNavigator1);
            this.groupBox2.Controls.Add(iD_врачаLabel1);
            this.groupBox2.Controls.Add(this.iD_врачаTextBox);
            this.groupBox2.Controls.Add(фИОLabel1);
            this.groupBox2.Controls.Add(this.фИОTextBox);
            this.groupBox2.Controls.Add(должностьLabel1);
            this.groupBox2.Controls.Add(this.должностьTextBox);
            this.groupBox2.Controls.Add(___кабинетаLabel1);
            this.groupBox2.Controls.Add(this.___кабинетаTextBox);
            this.groupBox2.Controls.Add(время_приемаLabel1);
            this.groupBox2.Controls.Add(this.время_приемаTextBox);
            this.groupBox2.Controls.Add(вид_оказываемых_услугLabel1);
            this.groupBox2.Controls.Add(this.вид_оказываемых_услугTextBox);
            this.groupBox2.Controls.Add(телефонLabel1);
            this.groupBox2.Controls.Add(this.телефонTextBox);
            this.groupBox2.Location = new System.Drawing.Point(17, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(291, 399);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Исходные данные";
            // 
            // iD_врачаLabel1
            // 
            iD_врачаLabel1.AutoSize = true;
            iD_врачаLabel1.Location = new System.Drawing.Point(6, 26);
            iD_врачаLabel1.Name = "iD_врачаLabel1";
            iD_врачаLabel1.Size = new System.Drawing.Size(53, 13);
            iD_врачаLabel1.TabIndex = 0;
            iD_врачаLabel1.Text = "ID врача:";
            // 
            // iD_врачаTextBox
            // 
            this.iD_врачаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.врачиBindingSource, "ID врача", true));
            this.iD_врачаTextBox.Location = new System.Drawing.Point(145, 23);
            this.iD_врачаTextBox.Name = "iD_врачаTextBox";
            this.iD_врачаTextBox.Size = new System.Drawing.Size(120, 20);
            this.iD_врачаTextBox.TabIndex = 1;
            // 
            // фИОLabel1
            // 
            фИОLabel1.AutoSize = true;
            фИОLabel1.Location = new System.Drawing.Point(6, 52);
            фИОLabel1.Name = "фИОLabel1";
            фИОLabel1.Size = new System.Drawing.Size(37, 13);
            фИОLabel1.TabIndex = 2;
            фИОLabel1.Text = "ФИО:";
            // 
            // фИОTextBox
            // 
            this.фИОTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.врачиBindingSource, "ФИО", true));
            this.фИОTextBox.Location = new System.Drawing.Point(145, 49);
            this.фИОTextBox.Name = "фИОTextBox";
            this.фИОTextBox.Size = new System.Drawing.Size(120, 20);
            this.фИОTextBox.TabIndex = 3;
            // 
            // должностьLabel1
            // 
            должностьLabel1.AutoSize = true;
            должностьLabel1.Location = new System.Drawing.Point(6, 78);
            должностьLabel1.Name = "должностьLabel1";
            должностьLabel1.Size = new System.Drawing.Size(68, 13);
            должностьLabel1.TabIndex = 4;
            должностьLabel1.Text = "Должность:";
            // 
            // должностьTextBox
            // 
            this.должностьTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.врачиBindingSource, "Должность", true));
            this.должностьTextBox.Location = new System.Drawing.Point(145, 75);
            this.должностьTextBox.Name = "должностьTextBox";
            this.должностьTextBox.Size = new System.Drawing.Size(120, 20);
            this.должностьTextBox.TabIndex = 5;
            // 
            // ___кабинетаLabel1
            // 
            ___кабинетаLabel1.AutoSize = true;
            ___кабинетаLabel1.Location = new System.Drawing.Point(6, 104);
            ___кабинетаLabel1.Name = "___кабинетаLabel1";
            ___кабинетаLabel1.Size = new System.Drawing.Size(71, 13);
            ___кабинетаLabel1.TabIndex = 6;
            ___кабинетаLabel1.Text = "№ кабинета:";
            // 
            // ___кабинетаTextBox
            // 
            this.___кабинетаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.врачиBindingSource, "№ кабинета", true));
            this.___кабинетаTextBox.Location = new System.Drawing.Point(145, 101);
            this.___кабинетаTextBox.Name = "___кабинетаTextBox";
            this.___кабинетаTextBox.Size = new System.Drawing.Size(120, 20);
            this.___кабинетаTextBox.TabIndex = 7;
            // 
            // время_приемаLabel1
            // 
            время_приемаLabel1.AutoSize = true;
            время_приемаLabel1.Location = new System.Drawing.Point(6, 130);
            время_приемаLabel1.Name = "время_приемаLabel1";
            время_приемаLabel1.Size = new System.Drawing.Size(84, 13);
            время_приемаLabel1.TabIndex = 8;
            время_приемаLabel1.Text = "Время приема:";
            // 
            // время_приемаTextBox
            // 
            this.время_приемаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.врачиBindingSource, "Время приема", true));
            this.время_приемаTextBox.Location = new System.Drawing.Point(145, 127);
            this.время_приемаTextBox.Name = "время_приемаTextBox";
            this.время_приемаTextBox.Size = new System.Drawing.Size(120, 20);
            this.время_приемаTextBox.TabIndex = 9;
            // 
            // вид_оказываемых_услугLabel1
            // 
            вид_оказываемых_услугLabel1.AutoSize = true;
            вид_оказываемых_услугLabel1.Location = new System.Drawing.Point(6, 156);
            вид_оказываемых_услугLabel1.Name = "вид_оказываемых_услугLabel1";
            вид_оказываемых_услугLabel1.Size = new System.Drawing.Size(133, 13);
            вид_оказываемых_услугLabel1.TabIndex = 10;
            вид_оказываемых_услугLabel1.Text = "Вид оказываемых услуг:";
            // 
            // вид_оказываемых_услугTextBox
            // 
            this.вид_оказываемых_услугTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.врачиBindingSource, "Вид оказываемых услуг", true));
            this.вид_оказываемых_услугTextBox.Location = new System.Drawing.Point(145, 153);
            this.вид_оказываемых_услугTextBox.Name = "вид_оказываемых_услугTextBox";
            this.вид_оказываемых_услугTextBox.Size = new System.Drawing.Size(120, 20);
            this.вид_оказываемых_услугTextBox.TabIndex = 11;
            // 
            // телефонLabel1
            // 
            телефонLabel1.AutoSize = true;
            телефонLabel1.Location = new System.Drawing.Point(6, 182);
            телефонLabel1.Name = "телефонLabel1";
            телефонLabel1.Size = new System.Drawing.Size(55, 13);
            телефонLabel1.TabIndex = 12;
            телефонLabel1.Text = "Телефон:";
            // 
            // телефонTextBox
            // 
            this.телефонTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.врачиBindingSource, "Телефон", true));
            this.телефонTextBox.Location = new System.Drawing.Point(145, 179);
            this.телефонTextBox.Name = "телефонTextBox";
            this.телефонTextBox.Size = new System.Drawing.Size(120, 20);
            this.телефонTextBox.TabIndex = 13;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.BindingSource = this.врачиBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.bindingNavigator1.Location = new System.Drawing.Point(3, 371);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(285, 25);
            this.bindingNavigator1.TabIndex = 14;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(iD_врачаLabel);
            this.groupBox3.Controls.Add(label1);
            this.groupBox3.Controls.Add(телефонLabel);
            this.groupBox3.Controls.Add(this.ФотоTB);
            this.groupBox3.Controls.Add(this.ДолжностьTB);
            this.groupBox3.Controls.Add(вид_оказываемых_услугLabel);
            this.groupBox3.Controls.Add(this.Время_приемаTB);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.Вид_оказ_услугTB);
            this.groupBox3.Controls.Add(время_приемаLabel);
            this.groupBox3.Controls.Add(this.ТелефонTB);
            this.groupBox3.Controls.Add(___кабинетаLabel);
            this.groupBox3.Controls.Add(должностьLabel);
            this.groupBox3.Controls.Add(фИОLabel);
            this.groupBox3.Controls.Add(this.кабинетTB);
            this.groupBox3.Controls.Add(this.ID_врачаTB);
            this.groupBox3.Controls.Add(this.ФИОTB);
            this.groupBox3.Location = new System.Drawing.Point(17, 17);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(291, 399);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Новая запись";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(iD_врачаLabel2);
            this.groupBox4.Controls.Add(this.iD_врачаTextBox1);
            this.groupBox4.Controls.Add(фИОLabel2);
            this.groupBox4.Controls.Add(this.фИОTextBox1);
            this.groupBox4.Controls.Add(должностьLabel2);
            this.groupBox4.Controls.Add(this.должностьTextBox1);
            this.groupBox4.Controls.Add(___кабинетаLabel2);
            this.groupBox4.Controls.Add(this.___кабинетаTextBox1);
            this.groupBox4.Controls.Add(время_приемаLabel2);
            this.groupBox4.Controls.Add(this.время_приемаTextBox1);
            this.groupBox4.Controls.Add(вид_оказываемых_услугLabel2);
            this.groupBox4.Controls.Add(this.вид_оказываемых_услугTextBox1);
            this.groupBox4.Controls.Add(телефонLabel2);
            this.groupBox4.Controls.Add(this.телефонTextBox1);
            this.groupBox4.Controls.Add(this.button3);
            this.groupBox4.Controls.Add(this.bindingNavigator2);
            this.groupBox4.Location = new System.Drawing.Point(17, 17);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(291, 399);
            this.groupBox4.TabIndex = 34;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Запись на удаление";
            // 
            // bindingNavigator2
            // 
            this.bindingNavigator2.AddNewItem = null;
            this.bindingNavigator2.BindingSource = this.врачиBindingSource;
            this.bindingNavigator2.CountItem = this.toolStripLabel1;
            this.bindingNavigator2.DeleteItem = null;
            this.bindingNavigator2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bindingNavigator2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripSeparator1,
            this.toolStripTextBox1,
            this.toolStripLabel1,
            this.toolStripSeparator2,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripSeparator3});
            this.bindingNavigator2.Location = new System.Drawing.Point(3, 371);
            this.bindingNavigator2.MoveFirstItem = this.toolStripButton1;
            this.bindingNavigator2.MoveLastItem = this.toolStripButton4;
            this.bindingNavigator2.MoveNextItem = this.toolStripButton3;
            this.bindingNavigator2.MovePreviousItem = this.toolStripButton2;
            this.bindingNavigator2.Name = "bindingNavigator2";
            this.bindingNavigator2.PositionItem = this.toolStripTextBox1;
            this.bindingNavigator2.Size = new System.Drawing.Size(285, 25);
            this.bindingNavigator2.TabIndex = 14;
            this.bindingNavigator2.Text = "bindingNavigator2";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(43, 22);
            this.toolStripLabel1.Text = "для {0}";
            this.toolStripLabel1.ToolTipText = "Общее число элементов";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.RightToLeftAutoMirrorImage = true;
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Переместить в начало";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.RightToLeftAutoMirrorImage = true;
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "Переместить назад";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.AccessibleName = "Положение";
            this.toolStripTextBox1.AutoSize = false;
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(50, 23);
            this.toolStripTextBox1.Text = "0";
            this.toolStripTextBox1.ToolTipText = "Текущее положение";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.RightToLeftAutoMirrorImage = true;
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "Переместить вперед";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.RightToLeftAutoMirrorImage = true;
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "Переместить в конец";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(145, 221);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 23);
            this.button3.TabIndex = 15;
            this.button3.Text = "DELETE";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // iD_врачаLabel2
            // 
            iD_врачаLabel2.AutoSize = true;
            iD_врачаLabel2.Location = new System.Drawing.Point(6, 26);
            iD_врачаLabel2.Name = "iD_врачаLabel2";
            iD_врачаLabel2.Size = new System.Drawing.Size(53, 13);
            iD_врачаLabel2.TabIndex = 15;
            iD_врачаLabel2.Text = "ID врача:";
            // 
            // iD_врачаTextBox1
            // 
            this.iD_врачаTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.врачиBindingSource, "ID врача", true));
            this.iD_врачаTextBox1.Location = new System.Drawing.Point(145, 23);
            this.iD_врачаTextBox1.Name = "iD_врачаTextBox1";
            this.iD_врачаTextBox1.Size = new System.Drawing.Size(120, 20);
            this.iD_врачаTextBox1.TabIndex = 16;
            // 
            // фИОLabel2
            // 
            фИОLabel2.AutoSize = true;
            фИОLabel2.Location = new System.Drawing.Point(6, 52);
            фИОLabel2.Name = "фИОLabel2";
            фИОLabel2.Size = new System.Drawing.Size(37, 13);
            фИОLabel2.TabIndex = 17;
            фИОLabel2.Text = "ФИО:";
            // 
            // фИОTextBox1
            // 
            this.фИОTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.врачиBindingSource, "ФИО", true));
            this.фИОTextBox1.Location = new System.Drawing.Point(145, 49);
            this.фИОTextBox1.Name = "фИОTextBox1";
            this.фИОTextBox1.Size = new System.Drawing.Size(120, 20);
            this.фИОTextBox1.TabIndex = 18;
            // 
            // должностьLabel2
            // 
            должностьLabel2.AutoSize = true;
            должностьLabel2.Location = new System.Drawing.Point(6, 78);
            должностьLabel2.Name = "должностьLabel2";
            должностьLabel2.Size = new System.Drawing.Size(68, 13);
            должностьLabel2.TabIndex = 19;
            должностьLabel2.Text = "Должность:";
            // 
            // должностьTextBox1
            // 
            this.должностьTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.врачиBindingSource, "Должность", true));
            this.должностьTextBox1.Location = new System.Drawing.Point(145, 75);
            this.должностьTextBox1.Name = "должностьTextBox1";
            this.должностьTextBox1.Size = new System.Drawing.Size(120, 20);
            this.должностьTextBox1.TabIndex = 20;
            // 
            // ___кабинетаLabel2
            // 
            ___кабинетаLabel2.AutoSize = true;
            ___кабинетаLabel2.Location = new System.Drawing.Point(6, 104);
            ___кабинетаLabel2.Name = "___кабинетаLabel2";
            ___кабинетаLabel2.Size = new System.Drawing.Size(71, 13);
            ___кабинетаLabel2.TabIndex = 21;
            ___кабинетаLabel2.Text = "№ кабинета:";
            // 
            // ___кабинетаTextBox1
            // 
            this.___кабинетаTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.врачиBindingSource, "№ кабинета", true));
            this.___кабинетаTextBox1.Location = new System.Drawing.Point(145, 101);
            this.___кабинетаTextBox1.Name = "___кабинетаTextBox1";
            this.___кабинетаTextBox1.Size = new System.Drawing.Size(120, 20);
            this.___кабинетаTextBox1.TabIndex = 22;
            // 
            // время_приемаLabel2
            // 
            время_приемаLabel2.AutoSize = true;
            время_приемаLabel2.Location = new System.Drawing.Point(6, 130);
            время_приемаLabel2.Name = "время_приемаLabel2";
            время_приемаLabel2.Size = new System.Drawing.Size(84, 13);
            время_приемаLabel2.TabIndex = 23;
            время_приемаLabel2.Text = "Время приема:";
            // 
            // время_приемаTextBox1
            // 
            this.время_приемаTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.врачиBindingSource, "Время приема", true));
            this.время_приемаTextBox1.Location = new System.Drawing.Point(145, 127);
            this.время_приемаTextBox1.Name = "время_приемаTextBox1";
            this.время_приемаTextBox1.Size = new System.Drawing.Size(120, 20);
            this.время_приемаTextBox1.TabIndex = 24;
            // 
            // вид_оказываемых_услугLabel2
            // 
            вид_оказываемых_услугLabel2.AutoSize = true;
            вид_оказываемых_услугLabel2.Location = new System.Drawing.Point(6, 156);
            вид_оказываемых_услугLabel2.Name = "вид_оказываемых_услугLabel2";
            вид_оказываемых_услугLabel2.Size = new System.Drawing.Size(133, 13);
            вид_оказываемых_услугLabel2.TabIndex = 25;
            вид_оказываемых_услугLabel2.Text = "Вид оказываемых услуг:";
            // 
            // вид_оказываемых_услугTextBox1
            // 
            this.вид_оказываемых_услугTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.врачиBindingSource, "Вид оказываемых услуг", true));
            this.вид_оказываемых_услугTextBox1.Location = new System.Drawing.Point(145, 153);
            this.вид_оказываемых_услугTextBox1.Name = "вид_оказываемых_услугTextBox1";
            this.вид_оказываемых_услугTextBox1.Size = new System.Drawing.Size(120, 20);
            this.вид_оказываемых_услугTextBox1.TabIndex = 26;
            // 
            // телефонLabel2
            // 
            телефонLabel2.AutoSize = true;
            телефонLabel2.Location = new System.Drawing.Point(6, 182);
            телефонLabel2.Name = "телефонLabel2";
            телефонLabel2.Size = new System.Drawing.Size(55, 13);
            телефонLabel2.TabIndex = 27;
            телефонLabel2.Text = "Телефон:";
            // 
            // телефонTextBox1
            // 
            this.телефонTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.врачиBindingSource, "Телефон", true));
            this.телефонTextBox1.Location = new System.Drawing.Point(145, 179);
            this.телефонTextBox1.Name = "телефонTextBox1";
            this.телефонTextBox1.Size = new System.Drawing.Size(120, 20);
            this.телефонTextBox1.TabIndex = 28;
            // 
            // ДолжностьTB
            // 
            this.ДолжностьTB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.врачиBindingSource, "Должность", true));
            this.ДолжностьTB.DataSource = this.штатноеРасписаниеBindingSource;
            this.ДолжностьTB.DisplayMember = "Должность";
            this.ДолжностьTB.FormattingEnabled = true;
            this.ДолжностьTB.Location = new System.Drawing.Point(145, 75);
            this.ДолжностьTB.Name = "ДолжностьTB";
            this.ДолжностьTB.Size = new System.Drawing.Size(120, 21);
            this.ДолжностьTB.TabIndex = 28;
            this.ДолжностьTB.ValueMember = "Должность";
            // 
            // Время_приемаTB
            // 
            this.Время_приемаTB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.врачиBindingSource, "Время приема", true));
            this.Время_приемаTB.DataSource = this.сменаподстановкаBindingSource;
            this.Время_приемаTB.DisplayMember = "ВремяПриема";
            this.Время_приемаTB.FormattingEnabled = true;
            this.Время_приемаTB.Location = new System.Drawing.Point(145, 127);
            this.Время_приемаTB.Name = "Время_приемаTB";
            this.Время_приемаTB.Size = new System.Drawing.Size(120, 21);
            this.Время_приемаTB.TabIndex = 32;
            this.Время_приемаTB.ValueMember = "ВремяПриема";
            // 
            // Вид_оказ_услугTB
            // 
            this.Вид_оказ_услугTB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.врачиBindingSource, "Вид оказываемых услуг", true));
            this.Вид_оказ_услугTB.DataSource = this.услугиподстановкаBindingSource;
            this.Вид_оказ_услугTB.DisplayMember = "Наименование направления услуг";
            this.Вид_оказ_услугTB.FormattingEnabled = true;
            this.Вид_оказ_услугTB.Location = new System.Drawing.Point(145, 153);
            this.Вид_оказ_услугTB.Name = "Вид_оказ_услугTB";
            this.Вид_оказ_услугTB.Size = new System.Drawing.Size(120, 21);
            this.Вид_оказ_услугTB.TabIndex = 34;
            this.Вид_оказ_услугTB.ValueMember = "Наименование направления услуг";
            // 
            // сменаподстановкаBindingSource
            // 
            this.сменаподстановкаBindingSource.DataMember = "Смена-подстановка";
            this.сменаподстановкаBindingSource.DataSource = this.стоматологияDataSet;
            // 
            // смена_подстановкаTableAdapter
            // 
            this.смена_подстановкаTableAdapter.ClearBeforeFill = true;
            // 
            // услугиподстановкаBindingSource
            // 
            this.услугиподстановкаBindingSource.DataMember = "Услуги-подстановка";
            this.услугиподстановкаBindingSource.DataSource = this.стоматологияDataSet;
            // 
            // услуги_подстановкаTableAdapter
            // 
            this.услуги_подстановкаTableAdapter.ClearBeforeFill = true;
            // 
            // ДолжностьTB1
            // 
            this.ДолжностьTB1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.врачиBindingSource, "Должность", true));
            this.ДолжностьTB1.DataSource = this.штатноеРасписаниеBindingSource;
            this.ДолжностьTB1.DisplayMember = "Должность";
            this.ДолжностьTB1.FormattingEnabled = true;
            this.ДолжностьTB1.Location = new System.Drawing.Point(145, 78);
            this.ДолжностьTB1.Name = "ДолжностьTB1";
            this.ДолжностьTB1.Size = new System.Drawing.Size(120, 21);
            this.ДолжностьTB1.TabIndex = 38;
            this.ДолжностьTB1.ValueMember = "Должность";
            // 
            // Время_приемаTB1
            // 
            this.Время_приемаTB1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.врачиBindingSource, "Время приема", true));
            this.Время_приемаTB1.DataSource = this.сменаподстановкаBindingSource;
            this.Время_приемаTB1.DisplayMember = "ВремяПриема";
            this.Время_приемаTB1.FormattingEnabled = true;
            this.Время_приемаTB1.Location = new System.Drawing.Point(145, 130);
            this.Время_приемаTB1.Name = "Время_приемаTB1";
            this.Время_приемаTB1.Size = new System.Drawing.Size(120, 21);
            this.Время_приемаTB1.TabIndex = 42;
            this.Время_приемаTB1.ValueMember = "ВремяПриема";
            // 
            // Вид_оказ_услугTB1
            // 
            this.Вид_оказ_услугTB1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.врачиBindingSource, "Вид оказываемых услуг", true));
            this.Вид_оказ_услугTB1.DataSource = this.услугиподстановкаBindingSource;
            this.Вид_оказ_услугTB1.DisplayMember = "Наименование направления услуг";
            this.Вид_оказ_услугTB1.FormattingEnabled = true;
            this.Вид_оказ_услугTB1.Location = new System.Drawing.Point(145, 156);
            this.Вид_оказ_услугTB1.Name = "Вид_оказ_услугTB1";
            this.Вид_оказ_услугTB1.Size = new System.Drawing.Size(120, 21);
            this.Вид_оказ_услугTB1.TabIndex = 44;
            this.Вид_оказ_услугTB1.ValueMember = "Наименование направления услуг";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 450);
            this.Controls.Add(this.tabControl1);
            this.MinimumSize = new System.Drawing.Size(663, 489);
            this.Name = "Form1";
            this.Text = "Database Integration";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.стоматологияDataSet)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.врачиBindingSource)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.стоматологияDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.штатноеРасписаниеBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).EndInit();
            this.bindingNavigator2.ResumeLayout(false);
            this.bindingNavigator2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.сменаподстановкаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.услугиподстановкаBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private стоматологияDataSet стоматологияDataSet;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.BindingSource врачиBindingSource;
        private стоматологияDataSetTableAdapters.ВрачиTableAdapter врачиTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDВрачаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn должностьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кабинетаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn времяПриемаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn видОказываемыхУслугDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn фотоВрачаDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn телефонDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private стоматологияDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox ТелефонTB;
        private System.Windows.Forms.TextBox кабинетTB;
        private System.Windows.Forms.TextBox ФИОTB;
        private System.Windows.Forms.TextBox ID_врачаTB;
        private System.Windows.Forms.TextBox ФотоTB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox ФотоTB1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox ТелефонTB1;
        private System.Windows.Forms.TextBox кабинетTB1;
        private System.Windows.Forms.TextBox ФИОTB1;
        private System.Windows.Forms.TextBox ID_врачаTB1;
        private System.Windows.Forms.BindingSource стоматологияDataSetBindingSource;
        private System.Windows.Forms.BindingSource штатноеРасписаниеBindingSource;
        private стоматологияDataSetTableAdapters.Штатное_расписаниеTableAdapter штатное_расписаниеTableAdapter;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox iD_врачаTextBox;
        private System.Windows.Forms.TextBox фИОTextBox;
        private System.Windows.Forms.TextBox должностьTextBox;
        private System.Windows.Forms.TextBox ___кабинетаTextBox;
        private System.Windows.Forms.TextBox время_приемаTextBox;
        private System.Windows.Forms.TextBox вид_оказываемых_услугTextBox;
        private System.Windows.Forms.TextBox телефонTextBox;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.BindingNavigator bindingNavigator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.TextBox iD_врачаTextBox1;
        private System.Windows.Forms.TextBox фИОTextBox1;
        private System.Windows.Forms.TextBox должностьTextBox1;
        private System.Windows.Forms.TextBox ___кабинетаTextBox1;
        private System.Windows.Forms.TextBox время_приемаTextBox1;
        private System.Windows.Forms.TextBox вид_оказываемых_услугTextBox1;
        private System.Windows.Forms.TextBox телефонTextBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox ДолжностьTB;
        private System.Windows.Forms.ComboBox Время_приемаTB;
        private System.Windows.Forms.ComboBox Вид_оказ_услугTB;
        private System.Windows.Forms.BindingSource сменаподстановкаBindingSource;
        private стоматологияDataSetTableAdapters.Смена_подстановкаTableAdapter смена_подстановкаTableAdapter;
        private System.Windows.Forms.BindingSource услугиподстановкаBindingSource;
        private стоматологияDataSetTableAdapters.Услуги_подстановкаTableAdapter услуги_подстановкаTableAdapter;
        private System.Windows.Forms.ComboBox ДолжностьTB1;
        private System.Windows.Forms.ComboBox Время_приемаTB1;
        private System.Windows.Forms.ComboBox Вид_оказ_услугTB1;
    }
}

