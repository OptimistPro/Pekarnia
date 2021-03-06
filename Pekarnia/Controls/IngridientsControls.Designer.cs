namespace Pekarnia.Controls
{
	partial class IngridientsControls
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

		#region Код, автоматически созданный конструктором компонентов

		/// <summary> 
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			this.table = new System.Windows.Forms.DataGridView();
			this.ids = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.names = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.count = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.unit_money = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.provider = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.Close_controls = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
			this.SuspendLayout();
			// 
			// table
			// 
			this.table.AllowUserToAddRows = false;
			this.table.AllowUserToDeleteRows = false;
			this.table.AllowUserToResizeColumns = false;
			this.table.AllowUserToResizeRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
			this.table.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.table.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.table.BackgroundColor = System.Drawing.SystemColors.Control;
			this.table.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.table.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.table.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlLight;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ids,
            this.names,
            this.count,
            this.unit,
            this.price,
            this.unit_money,
            this.provider});
			this.table.EnableHeadersVisualStyles = false;
			this.table.Location = new System.Drawing.Point(15, 44);
			this.table.Name = "table";
			this.table.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.ControlDark;
			dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.table.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
			this.table.RowHeadersVisible = false;
			this.table.Size = new System.Drawing.Size(770, 351);
			this.table.TabIndex = 5;
			this.table.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.table_CellClick);
			// 
			// ids
			// 
			this.ids.HeaderText = "ids";
			this.ids.Name = "ids";
			this.ids.Visible = false;
			// 
			// names
			// 
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.names.DefaultCellStyle = dataGridViewCellStyle3;
			this.names.HeaderText = "Название";
			this.names.Name = "names";
			// 
			// count
			// 
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.count.DefaultCellStyle = dataGridViewCellStyle4;
			this.count.HeaderText = "Количество";
			this.count.Name = "count";
			// 
			// unit
			// 
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.unit.DefaultCellStyle = dataGridViewCellStyle5;
			this.unit.HeaderText = "Измерение";
			this.unit.Name = "unit";
			// 
			// price
			// 
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.price.DefaultCellStyle = dataGridViewCellStyle6;
			this.price.HeaderText = "Цена";
			this.price.Name = "price";
			// 
			// unit_money
			// 
			dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.unit_money.DefaultCellStyle = dataGridViewCellStyle7;
			this.unit_money.HeaderText = "Валюта";
			this.unit_money.Name = "unit_money";
			// 
			// provider
			// 
			dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.provider.DefaultCellStyle = dataGridViewCellStyle8;
			this.provider.HeaderText = "Поставщик";
			this.provider.Name = "provider";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(9, 10);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(181, 31);
			this.label1.TabIndex = 4;
			this.label1.Text = "Ингредиенты";
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button1.Location = new System.Drawing.Point(666, 13);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(87, 28);
			this.button1.TabIndex = 7;
			this.button1.Text = "Добавить";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Close_controls
			// 
			this.Close_controls.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.Close_controls.AutoSize = true;
			this.Close_controls.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Close_controls.Location = new System.Drawing.Point(759, 16);
			this.Close_controls.Name = "Close_controls";
			this.Close_controls.Size = new System.Drawing.Size(26, 25);
			this.Close_controls.TabIndex = 6;
			this.Close_controls.Text = "Х";
			this.Close_controls.Click += new System.EventHandler(this.Close_controls_Click);
			// 
			// IngridientsControls
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.button1);
			this.Controls.Add(this.Close_controls);
			this.Controls.Add(this.table);
			this.Controls.Add(this.label1);
			this.Name = "IngridientsControls";
			this.Size = new System.Drawing.Size(800, 426);
			((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView table;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label Close_controls;
		private System.Windows.Forms.DataGridViewTextBoxColumn ids;
		private System.Windows.Forms.DataGridViewTextBoxColumn names;
		private System.Windows.Forms.DataGridViewTextBoxColumn count;
		private System.Windows.Forms.DataGridViewTextBoxColumn unit;
		private System.Windows.Forms.DataGridViewTextBoxColumn price;
		private System.Windows.Forms.DataGridViewTextBoxColumn unit_money;
		private System.Windows.Forms.DataGridViewTextBoxColumn provider;
	}
}
