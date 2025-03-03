﻿namespace CapaPresentacion.Modales
{
    partial class mdDetalleGrupoPermiso
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mdDetalleGrupoPermiso));
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelSubTitulo = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.comboBoxEstado = new System.Windows.Forms.ComboBox();
            this.labelEstado = new System.Windows.Forms.Label();
            this.textBoxNombreGrupo = new System.Windows.Forms.TextBox();
            this.labelNombreGrupo = new System.Windows.Forms.Label();
            this.labelInfoPermiso = new System.Windows.Forms.Label();
            this.buttonVolver = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.buttonSeleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.IdComponente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoPermiso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.buttonConfirmar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.labelSubTitulo);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1110, 65);
            this.panel1.TabIndex = 0;
            // 
            // labelSubTitulo
            // 
            this.labelSubTitulo.AutoSize = true;
            this.labelSubTitulo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelSubTitulo.Font = new System.Drawing.Font("Bodoni MT Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSubTitulo.Location = new System.Drawing.Point(13, 10);
            this.labelSubTitulo.Name = "labelSubTitulo";
            this.labelSubTitulo.Size = new System.Drawing.Size(170, 38);
            this.labelSubTitulo.TabIndex = 51;
            this.labelSubTitulo.Text = "Detalle del grupo";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Controls.Add(this.textBoxId);
            this.panel2.Controls.Add(this.comboBoxEstado);
            this.panel2.Controls.Add(this.labelEstado);
            this.panel2.Controls.Add(this.textBoxNombreGrupo);
            this.panel2.Controls.Add(this.labelNombreGrupo);
            this.panel2.Controls.Add(this.labelInfoPermiso);
            this.panel2.Location = new System.Drawing.Point(12, 83);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1110, 95);
            this.panel2.TabIndex = 1;
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(231, 23);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(24, 20);
            this.textBoxId.TabIndex = 44;
            this.textBoxId.Visible = false;
            // 
            // comboBoxEstado
            // 
            this.comboBoxEstado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEstado.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxEstado.FormattingEnabled = true;
            this.comboBoxEstado.ItemHeight = 19;
            this.comboBoxEstado.Location = new System.Drawing.Point(390, 53);
            this.comboBoxEstado.Name = "comboBoxEstado";
            this.comboBoxEstado.Size = new System.Drawing.Size(175, 27);
            this.comboBoxEstado.TabIndex = 43;
            // 
            // labelEstado
            // 
            this.labelEstado.AutoSize = true;
            this.labelEstado.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEstado.Location = new System.Drawing.Point(329, 52);
            this.labelEstado.Name = "labelEstado";
            this.labelEstado.Size = new System.Drawing.Size(55, 23);
            this.labelEstado.TabIndex = 14;
            this.labelEstado.Text = "Estado:";
            // 
            // textBoxNombreGrupo
            // 
            this.textBoxNombreGrupo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxNombreGrupo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxNombreGrupo.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombreGrupo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.textBoxNombreGrupo.Location = new System.Drawing.Point(148, 53);
            this.textBoxNombreGrupo.Name = "textBoxNombreGrupo";
            this.textBoxNombreGrupo.Size = new System.Drawing.Size(175, 27);
            this.textBoxNombreGrupo.TabIndex = 1;
            // 
            // labelNombreGrupo
            // 
            this.labelNombreGrupo.AutoSize = true;
            this.labelNombreGrupo.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreGrupo.Location = new System.Drawing.Point(17, 52);
            this.labelNombreGrupo.Name = "labelNombreGrupo";
            this.labelNombreGrupo.Size = new System.Drawing.Size(125, 23);
            this.labelNombreGrupo.TabIndex = 2;
            this.labelNombreGrupo.Text = "Nombre del grupo:";
            // 
            // labelInfoPermiso
            // 
            this.labelInfoPermiso.AutoSize = true;
            this.labelInfoPermiso.Font = new System.Drawing.Font("Bodoni MT Condensed", 20.25F);
            this.labelInfoPermiso.Location = new System.Drawing.Point(16, 13);
            this.labelInfoPermiso.Name = "labelInfoPermiso";
            this.labelInfoPermiso.Size = new System.Drawing.Size(198, 32);
            this.labelInfoPermiso.TabIndex = 1;
            this.labelInfoPermiso.Text = "Información del permiso";
            // 
            // buttonVolver
            // 
            this.buttonVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.buttonVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonVolver.FlatAppearance.BorderSize = 0;
            this.buttonVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVolver.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVolver.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonVolver.Location = new System.Drawing.Point(1008, 569);
            this.buttonVolver.Name = "buttonVolver";
            this.buttonVolver.Size = new System.Drawing.Size(80, 30);
            this.buttonVolver.TabIndex = 6;
            this.buttonVolver.Text = "Volver";
            this.buttonVolver.UseVisualStyleBackColor = false;
            this.buttonVolver.Click += new System.EventHandler(this.buttonVolver_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bahnschrift Condensed", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.buttonSeleccionar,
            this.IdComponente,
            this.nombre,
            this.tipoPermiso,
            this.estado,
            this.estadoValor});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.Location = new System.Drawing.Point(12, 184);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView.RowTemplate.Height = 28;
            this.dataGridView.Size = new System.Drawing.Size(954, 415);
            this.dataGridView.TabIndex = 90;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            this.dataGridView.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGridView_CellPainting);
            // 
            // buttonSeleccionar
            // 
            this.buttonSeleccionar.HeaderText = "";
            this.buttonSeleccionar.Name = "buttonSeleccionar";
            this.buttonSeleccionar.ReadOnly = true;
            this.buttonSeleccionar.Width = 30;
            // 
            // IdComponente
            // 
            this.IdComponente.HeaderText = "IdComponente";
            this.IdComponente.Name = "IdComponente";
            this.IdComponente.ReadOnly = true;
            this.IdComponente.Visible = false;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 200;
            // 
            // tipoPermiso
            // 
            this.tipoPermiso.HeaderText = "Tipo de permiso";
            this.tipoPermiso.Name = "tipoPermiso";
            this.tipoPermiso.ReadOnly = true;
            this.tipoPermiso.Width = 200;
            // 
            // estado
            // 
            this.estado.HeaderText = "Estado";
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            this.estado.Visible = false;
            // 
            // estadoValor
            // 
            this.estadoValor.HeaderText = "Estado";
            this.estadoValor.Name = "estadoValor";
            this.estadoValor.ReadOnly = true;
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.BackColor = System.Drawing.Color.Red;
            this.buttonEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEliminar.FlatAppearance.BorderSize = 0;
            this.buttonEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEliminar.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminar.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonEliminar.Location = new System.Drawing.Point(972, 220);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(150, 30);
            this.buttonEliminar.TabIndex = 4;
            this.buttonEliminar.Text = "Eliminar permiso";
            this.buttonEliminar.UseVisualStyleBackColor = false;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAgregar.FlatAppearance.BorderSize = 0;
            this.buttonAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAgregar.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAgregar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonAgregar.Location = new System.Drawing.Point(972, 184);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(150, 30);
            this.buttonAgregar.TabIndex = 3;
            this.buttonAgregar.Text = "Agregar permiso";
            this.buttonAgregar.UseVisualStyleBackColor = false;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // buttonConfirmar
            // 
            this.buttonConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(204)))), ((int)(((byte)(112)))));
            this.buttonConfirmar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonConfirmar.FlatAppearance.BorderSize = 0;
            this.buttonConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConfirmar.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfirmar.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonConfirmar.Location = new System.Drawing.Point(972, 533);
            this.buttonConfirmar.Name = "buttonConfirmar";
            this.buttonConfirmar.Size = new System.Drawing.Size(150, 30);
            this.buttonConfirmar.TabIndex = 5;
            this.buttonConfirmar.Text = "Confirmar";
            this.buttonConfirmar.UseVisualStyleBackColor = false;
            this.buttonConfirmar.Click += new System.EventHandler(this.buttonConfirmar_Click);
            // 
            // mdDetalleGrupoPermiso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1134, 611);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonAgregar);
            this.Controls.Add(this.buttonConfirmar);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.buttonVolver);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1150, 650);
            this.MinimumSize = new System.Drawing.Size(1150, 650);
            this.Name = "mdDetalleGrupoPermiso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalle grupo permiso";
            this.Load += new System.EventHandler(this.mdDetalleGrupoPermiso_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelSubTitulo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelInfoPermiso;
        private System.Windows.Forms.Label labelNombreGrupo;
        private System.Windows.Forms.Label labelEstado;
        private System.Windows.Forms.TextBox textBoxNombreGrupo;
        private System.Windows.Forms.ComboBox comboBoxEstado;
        private System.Windows.Forms.Button buttonVolver;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewButtonColumn buttonSeleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdComponente;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoPermiso;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoValor;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.Button buttonConfirmar;
        private System.Windows.Forms.TextBox textBoxId;
    }
}