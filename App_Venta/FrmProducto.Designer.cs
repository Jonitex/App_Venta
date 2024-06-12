namespace App_Venta
{
    partial class FrmProductos
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProductos));
            this.sesionventa = new DevExpress.Xpo.UnitOfWork(this.components);
            this.bt_Agregar = new DevExpress.XtraEditors.SimpleButton();
            this.searchCategorias = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.xpCategoria = new DevExpress.Xpo.XPCollection(this.components);
            this.searchCategoriaView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdcategoria = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFecha = new DevExpress.XtraEditors.DateEdit();
            this.xpProductos = new DevExpress.Xpo.XPCollection(this.components);
            this.txtPrecio = new DevExpress.XtraEditors.TextEdit();
            this.gridproductos = new DevExpress.XtraGrid.GridControl();
            this.gridViewproductos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha_Vencimiento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrecio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstante = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtNombre = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEstante = new DevExpress.XtraEditors.TextEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnEliminar = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.sesionventa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchCategorias.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCategoria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchCategoriaView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFecha.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFecha.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridproductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewproductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEstante.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_Agregar
            // 
            this.bt_Agregar.Appearance.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Agregar.Appearance.ForeColor = System.Drawing.Color.Black;
            this.bt_Agregar.Appearance.Options.UseFont = true;
            this.bt_Agregar.Appearance.Options.UseForeColor = true;
            this.bt_Agregar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bt_Agregar.ImageOptions.Image")));
            this.bt_Agregar.Location = new System.Drawing.Point(12, 285);
            this.bt_Agregar.Name = "bt_Agregar";
            this.bt_Agregar.Size = new System.Drawing.Size(177, 41);
            this.bt_Agregar.TabIndex = 0;
            this.bt_Agregar.Text = "Agregar producto";
            this.bt_Agregar.Click += new System.EventHandler(this.bt_Agregar_Click);
            // 
            // searchCategorias
            // 
            this.searchCategorias.Cursor = System.Windows.Forms.Cursors.Default;
            this.searchCategorias.Location = new System.Drawing.Point(119, 44);
            this.searchCategorias.Name = "searchCategorias";
            this.searchCategorias.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.searchCategorias.Properties.DataSource = this.xpCategoria;
            this.searchCategorias.Properties.DisplayMember = "Nombre";
            this.searchCategorias.Properties.PopupView = this.searchCategoriaView;
            this.searchCategorias.Properties.ValueMember = "Idcategoria";
            this.searchCategorias.Size = new System.Drawing.Size(188, 20);
            this.searchCategorias.TabIndex = 1;
            // 
            // xpCategoria
            // 
            this.xpCategoria.CriteriaString = "[Estado] = True";
            this.xpCategoria.ObjectType = typeof(App_Venta.venta.Categoria);
            this.xpCategoria.Session = this.sesionventa;
            // 
            // searchCategoriaView
            // 
            this.searchCategoriaView.ActiveFilterString = "[Estado] = True";
            this.searchCategoriaView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdcategoria,
            this.gridColumn3,
            this.gridColumn4});
            this.searchCategoriaView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchCategoriaView.Name = "searchCategoriaView";
            this.searchCategoriaView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchCategoriaView.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.searchCategoriaView.OptionsView.ShowGroupPanel = false;
            this.searchCategoriaView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumn4, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.searchCategoriaView.SynchronizeClones = false;
            // 
            // colIdcategoria
            // 
            this.colIdcategoria.FieldName = "Idcategoria";
            this.colIdcategoria.Name = "colIdcategoria";
            this.colIdcategoria.Visible = true;
            this.colIdcategoria.VisibleIndex = 0;
            // 
            // gridColumn3
            // 
            this.gridColumn3.FieldName = "Nombre";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            // 
            // gridColumn4
            // 
            this.gridColumn4.FieldName = "Estado";
            this.gridColumn4.Name = "gridColumn4";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Categria:";
            // 
            // txtFecha
            // 
            this.txtFecha.EditValue = null;
            this.txtFecha.Location = new System.Drawing.Point(119, 138);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtFecha.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtFecha.Properties.DisplayFormat.FormatString = "";
            this.txtFecha.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtFecha.Properties.EditFormat.FormatString = "";
            this.txtFecha.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtFecha.Properties.MaskSettings.Set("mask", "");
            this.txtFecha.Size = new System.Drawing.Size(133, 20);
            this.txtFecha.TabIndex = 3;
            // 
            // xpProductos
            // 
            this.xpProductos.ObjectType = typeof(App_Venta.venta.Producto);
            this.xpProductos.Session = this.sesionventa;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(119, 168);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtPrecio.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.txtPrecio.Properties.MaskSettings.Set("mask", "c");
            this.txtPrecio.Size = new System.Drawing.Size(133, 20);
            this.txtPrecio.TabIndex = 4;
            // 
            // gridproductos
            // 
            this.gridproductos.DataSource = this.xpProductos;
            this.gridproductos.Location = new System.Drawing.Point(475, 47);
            this.gridproductos.MainView = this.gridViewproductos;
            this.gridproductos.Name = "gridproductos";
            this.gridproductos.Size = new System.Drawing.Size(538, 322);
            this.gridproductos.TabIndex = 5;
            this.gridproductos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewproductos});
            // 
            // gridViewproductos
            // 
            this.gridViewproductos.ActiveFilterString = "[Estado] = True";
            this.gridViewproductos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colNombre,
            this.colFecha_Vencimiento,
            this.colPrecio,
            this.colEstante,
            this.gridColumn1,
            this.gridColumn2,
            this.colEstado});
            this.gridViewproductos.GridControl = this.gridproductos;
            this.gridViewproductos.Name = "gridViewproductos";
            this.gridViewproductos.OptionsBehavior.Editable = false;
            this.gridViewproductos.OptionsFind.AlwaysVisible = true;
            this.gridViewproductos.OptionsFind.FindNullPrompt = "Introduzca texto a buscar.";
            this.gridViewproductos.OptionsSelection.MultiSelect = true;
            this.gridViewproductos.OptionsView.EnableAppearanceEvenRow = true;
            this.gridViewproductos.OptionsView.ShowDetailButtons = false;
            this.gridViewproductos.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gridViewproductos.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // colId
            // 
            this.colId.AppearanceHeader.Options.UseTextOptions = true;
            this.colId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colId.Caption = "Código";
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            // 
            // colNombre
            // 
            this.colNombre.AppearanceHeader.Options.UseTextOptions = true;
            this.colNombre.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNombre.Caption = "Nombre";
            this.colNombre.FieldName = "Nombre";
            this.colNombre.Name = "colNombre";
            // 
            // colFecha_Vencimiento
            // 
            this.colFecha_Vencimiento.AppearanceHeader.Options.UseTextOptions = true;
            this.colFecha_Vencimiento.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFecha_Vencimiento.Caption = "Fecha Vencimiento";
            this.colFecha_Vencimiento.FieldName = "Fecha_Vencimiento";
            this.colFecha_Vencimiento.Name = "colFecha_Vencimiento";
            // 
            // colPrecio
            // 
            this.colPrecio.AppearanceHeader.Options.UseTextOptions = true;
            this.colPrecio.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPrecio.Caption = "Precio";
            this.colPrecio.FieldName = "Precio";
            this.colPrecio.Name = "colPrecio";
            this.colPrecio.Visible = true;
            this.colPrecio.VisibleIndex = 0;
            // 
            // colEstante
            // 
            this.colEstante.AppearanceHeader.Options.UseTextOptions = true;
            this.colEstante.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEstante.Caption = "Estante";
            this.colEstante.FieldName = "Estante";
            this.colEstante.Name = "colEstante";
            this.colEstante.Visible = true;
            this.colEstante.VisibleIndex = 1;
            // 
            // gridColumn1
            // 
            this.gridColumn1.FieldName = "Idcategoria!";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.Caption = "Categoria";
            this.gridColumn2.FieldName = "Idcategoria.Nombre";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 2;
            // 
            // colEstado
            // 
            this.colEstado.Caption = "colEstado";
            this.colEstado.FieldName = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.OptionsFilter.ShowBlanksFilterItems = DevExpress.Utils.DefaultBoolean.True;
            this.colEstado.Visible = true;
            this.colEstado.VisibleIndex = 3;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(119, 101);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(133, 20);
            this.txtNombre.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Precio:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Fecha:";
            // 
            // txtEstante
            // 
            this.txtEstante.Location = new System.Drawing.Point(119, 204);
            this.txtEstante.Name = "txtEstante";
            this.txtEstante.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtEstante.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.txtEstante.Properties.MaskSettings.Set("mask", "d");
            this.txtEstante.Size = new System.Drawing.Size(133, 20);
            this.txtEstante.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Estante:";
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Appearance.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.Appearance.ForeColor = System.Drawing.Color.Black;
            this.BtnEliminar.Appearance.Options.UseFont = true;
            this.BtnEliminar.Appearance.Options.UseForeColor = true;
            this.BtnEliminar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnEliminar.ImageOptions.Image")));
            this.BtnEliminar.Location = new System.Drawing.Point(213, 285);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(177, 41);
            this.BtnEliminar.TabIndex = 12;
            this.BtnEliminar.Text = "Eliminar Producto";
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // FrmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 450);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEstante);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.gridproductos);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchCategorias);
            this.Controls.Add(this.bt_Agregar);
            this.Controls.Add(this.txtFecha);
            this.Name = "FrmProductos";
            this.Text = "hrome";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmProductos_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sesionventa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchCategorias.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCategoria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchCategoriaView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFecha.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFecha.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridproductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewproductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEstante.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.Xpo.UnitOfWork sesionventa;
        private DevExpress.Xpo.XPCollection xpProductos;
        private DevExpress.XtraEditors.SimpleButton bt_Agregar;
        private DevExpress.XtraEditors.SearchLookUpEdit searchCategorias;
        private DevExpress.XtraGrid.Views.Grid.GridView searchCategoriaView;
        private DevExpress.Xpo.XPCollection xpCategoria;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.DateEdit txtFecha;
        private DevExpress.XtraEditors.TextEdit txtPrecio;
        private DevExpress.XtraGrid.GridControl gridproductos;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewproductos;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colNombre;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha_Vencimiento;
        private DevExpress.XtraGrid.Columns.GridColumn colPrecio;
        private DevExpress.XtraGrid.Columns.GridColumn colEstante;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.TextEdit txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.TextEdit txtEstante;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.SimpleButton BtnEliminar;
        public DevExpress.XtraGrid.Columns.GridColumn colEstado;
        private DevExpress.XtraGrid.Columns.GridColumn colIdcategoria;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
    }
}

