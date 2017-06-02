namespace EasyRest
{
    partial class FrmMenuPrincipal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuPrincipal));
            this.MenuOpciones = new DevComponents.DotNetBar.RadialMenu();
            this.ItemPerfil = new DevComponents.DotNetBar.RadialMenuItem();
            this.ItemIdioma = new DevComponents.DotNetBar.RadialMenuItem();
            this.ItemSesion = new DevComponents.DotNetBar.RadialMenuItem();
            this.radialMenuItem1 = new DevComponents.DotNetBar.RadialMenuItem();
            this.lblNomUsu = new DevComponents.DotNetBar.LabelX();
            this.lblHora = new DevComponents.DotNetBar.LabelX();
            this.metroTilePanel1 = new DevComponents.DotNetBar.Metro.MetroTilePanel();
            this.itemContainer1 = new DevComponents.DotNetBar.ItemContainer();
            this.itemSalas = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.metroTileItem2 = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.metroTileItem3 = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.metroTileItem4 = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.metroTileItem5 = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.lblMenuPrincipal = new DevComponents.DotNetBar.LabelX();
            this.metroTilePanel2 = new DevComponents.DotNetBar.Metro.MetroTilePanel();
            this.itemContainer2 = new DevComponents.DotNetBar.ItemContainer();
            this.metroTileItem1 = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.metroTileItem6 = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.metroTileItem7 = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.metroTileItem8 = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.metroTileItem9 = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.timerHora = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // MenuOpciones
            // 
            this.MenuOpciones.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.ItemPerfil,
            this.ItemIdioma,
            this.ItemSesion,
            this.radialMenuItem1});
            this.MenuOpciones.Location = new System.Drawing.Point(1293, 62);
            this.MenuOpciones.Name = "MenuOpciones";
            this.MenuOpciones.Size = new System.Drawing.Size(28, 28);
            this.MenuOpciones.Symbol = "";
            this.MenuOpciones.TabIndex = 5;
            // 
            // ItemPerfil
            // 
            this.ItemPerfil.Name = "ItemPerfil";
            this.ItemPerfil.Text = "Mi Perfil";
            // 
            // ItemIdioma
            // 
            this.ItemIdioma.Name = "ItemIdioma";
            this.ItemIdioma.Text = "Idioma";
            // 
            // ItemSesion
            // 
            this.ItemSesion.Name = "ItemSesion";
            this.ItemSesion.Text = "Cerrar Sesion";
            // 
            // radialMenuItem1
            // 
            this.radialMenuItem1.Name = "radialMenuItem1";
            this.radialMenuItem1.Text = "Item 4";
            // 
            // lblNomUsu
            // 
            this.lblNomUsu.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblNomUsu.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblNomUsu.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomUsu.Location = new System.Drawing.Point(3, -2);
            this.lblNomUsu.Name = "lblNomUsu";
            this.lblNomUsu.Size = new System.Drawing.Size(1265, 27);
            this.lblNomUsu.TabIndex = 7;
            this.lblNomUsu.Text = "Ricardo Misme - B039806";
            this.lblNomUsu.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // lblHora
            // 
            this.lblHora.BackColor = System.Drawing.Color.SteelBlue;
            // 
            // 
            // 
            this.lblHora.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblHora.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.Black;
            this.lblHora.Location = new System.Drawing.Point(1124, -2);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(104, 27);
            this.lblHora.TabIndex = 9;
            this.lblHora.Text = "00:00:00";
            this.lblHora.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // metroTilePanel1
            // 
            // 
            // 
            // 
            this.metroTilePanel1.BackgroundStyle.Class = "MetroTilePanel";
            this.metroTilePanel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroTilePanel1.ContainerControlProcessDialogKey = true;
            this.metroTilePanel1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemContainer1});
            this.metroTilePanel1.Location = new System.Drawing.Point(151, 130);
            this.metroTilePanel1.Name = "metroTilePanel1";
            this.metroTilePanel1.Size = new System.Drawing.Size(960, 148);
            this.metroTilePanel1.TabIndex = 10;
            this.metroTilePanel1.Text = "metroTilePanel1";
            // 
            // itemContainer1
            // 
            // 
            // 
            // 
            this.itemContainer1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer1.Name = "itemContainer1";
            this.itemContainer1.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemSalas,
            this.metroTileItem2,
            this.metroTileItem3,
            this.metroTileItem4,
            this.metroTileItem5});
            // 
            // 
            // 
            this.itemContainer1.TitleStyle.Class = "MetroTileGroupTitle";
            this.itemContainer1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // itemSalas
            // 
            this.itemSalas.Image = ((System.Drawing.Image)(resources.GetObject("itemSalas.Image")));
            this.itemSalas.Name = "itemSalas";
            this.itemSalas.SymbolColor = System.Drawing.Color.Empty;
            this.itemSalas.Text = "Salas";
            this.itemSalas.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Magenta;
            // 
            // 
            // 
            this.itemSalas.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemSalas.TileStyle.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemSalas.TileStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.itemSalas.TileStyle.TextColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.itemSalas.TitleTextColor = System.Drawing.Color.Black;
            this.itemSalas.TitleTextFont = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // metroTileItem2
            // 
            this.metroTileItem2.Name = "metroTileItem2";
            this.metroTileItem2.NotificationMarkColor = System.Drawing.Color.White;
            this.metroTileItem2.SymbolColor = System.Drawing.Color.Empty;
            this.metroTileItem2.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Orange;
            // 
            // 
            // 
            this.metroTileItem2.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // metroTileItem3
            // 
            this.metroTileItem3.Name = "metroTileItem3";
            this.metroTileItem3.SymbolColor = System.Drawing.Color.Empty;
            this.metroTileItem3.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Default;
            // 
            // 
            // 
            this.metroTileItem3.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // metroTileItem4
            // 
            this.metroTileItem4.Name = "metroTileItem4";
            this.metroTileItem4.SymbolColor = System.Drawing.Color.Empty;
            this.metroTileItem4.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Default;
            // 
            // 
            // 
            this.metroTileItem4.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroTileItem4.TileStyle.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroTileItem4.TileStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.metroTileItem4.TileStyle.TextColor = System.Drawing.SystemColors.ActiveCaptionText;
            // 
            // metroTileItem5
            // 
            this.metroTileItem5.Name = "metroTileItem5";
            this.metroTileItem5.SymbolColor = System.Drawing.Color.Empty;
            this.metroTileItem5.Text = "metroTileItem5";
            this.metroTileItem5.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Default;
            // 
            // 
            // 
            this.metroTileItem5.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroTileItem5.TileStyle.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroTileItem5.TileStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.metroTileItem5.TileStyle.TextColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroTileItem5.TitleText = "hola";
            this.metroTileItem5.TitleTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // lblMenuPrincipal
            // 
            // 
            // 
            // 
            this.lblMenuPrincipal.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblMenuPrincipal.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuPrincipal.Location = new System.Drawing.Point(492, 51);
            this.lblMenuPrincipal.Name = "lblMenuPrincipal";
            this.lblMenuPrincipal.Size = new System.Drawing.Size(303, 57);
            this.lblMenuPrincipal.TabIndex = 11;
            this.lblMenuPrincipal.Text = "MENU PRINCIPAL";
            this.lblMenuPrincipal.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // metroTilePanel2
            // 
            // 
            // 
            // 
            this.metroTilePanel2.BackgroundStyle.Class = "MetroTilePanel";
            this.metroTilePanel2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroTilePanel2.ContainerControlProcessDialogKey = true;
            this.metroTilePanel2.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemContainer2});
            this.metroTilePanel2.Location = new System.Drawing.Point(151, 307);
            this.metroTilePanel2.Name = "metroTilePanel2";
            this.metroTilePanel2.Size = new System.Drawing.Size(960, 148);
            this.metroTilePanel2.TabIndex = 12;
            this.metroTilePanel2.Text = "metroTilePanel2";
            // 
            // itemContainer2
            // 
            // 
            // 
            // 
            this.itemContainer2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer2.Name = "itemContainer2";
            this.itemContainer2.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.metroTileItem1,
            this.metroTileItem6,
            this.metroTileItem7,
            this.metroTileItem8,
            this.metroTileItem9});
            // 
            // 
            // 
            this.itemContainer2.TitleStyle.Class = "MetroTileGroupTitle";
            this.itemContainer2.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // metroTileItem1
            // 
            this.metroTileItem1.Image = ((System.Drawing.Image)(resources.GetObject("metroTileItem1.Image")));
            this.metroTileItem1.Name = "metroTileItem1";
            this.metroTileItem1.SymbolColor = System.Drawing.Color.Empty;
            this.metroTileItem1.Text = "Salon";
            this.metroTileItem1.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Magenta;
            // 
            // 
            // 
            this.metroTileItem1.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroTileItem1.TileStyle.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroTileItem1.TileStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.metroTileItem1.TileStyle.TextColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroTileItem1.TitleText = "Salas";
            this.metroTileItem1.TitleTextColor = System.Drawing.Color.Black;
            this.metroTileItem1.TitleTextFont = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // metroTileItem6
            // 
            this.metroTileItem6.Image = ((System.Drawing.Image)(resources.GetObject("metroTileItem6.Image")));
            this.metroTileItem6.Name = "metroTileItem6";
            this.metroTileItem6.NotificationMarkColor = System.Drawing.Color.White;
            this.metroTileItem6.SymbolColor = System.Drawing.Color.Empty;
            this.metroTileItem6.Text = "Patio";
            this.metroTileItem6.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Orange;
            // 
            // 
            // 
            this.metroTileItem6.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroTileItem6.TileStyle.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroTileItem6.TileStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.metroTileItem6.TileStyle.TextColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroTileItem6.TitleText = "Salas";
            this.metroTileItem6.TitleTextColor = System.Drawing.Color.Black;
            this.metroTileItem6.TitleTextFont = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // metroTileItem7
            // 
            this.metroTileItem7.Name = "metroTileItem7";
            this.metroTileItem7.SymbolColor = System.Drawing.Color.Empty;
            this.metroTileItem7.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Default;
            // 
            // 
            // 
            this.metroTileItem7.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // metroTileItem8
            // 
            this.metroTileItem8.Name = "metroTileItem8";
            this.metroTileItem8.SymbolColor = System.Drawing.Color.Empty;
            this.metroTileItem8.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Default;
            // 
            // 
            // 
            this.metroTileItem8.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroTileItem8.TileStyle.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroTileItem8.TileStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.metroTileItem8.TileStyle.TextColor = System.Drawing.SystemColors.ActiveCaptionText;
            // 
            // metroTileItem9
            // 
            this.metroTileItem9.Name = "metroTileItem9";
            this.metroTileItem9.SymbolColor = System.Drawing.Color.Empty;
            this.metroTileItem9.Text = "metroTileItem5";
            this.metroTileItem9.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Default;
            // 
            // 
            // 
            this.metroTileItem9.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroTileItem9.TileStyle.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroTileItem9.TileStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.metroTileItem9.TileStyle.TextColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroTileItem9.TitleText = "hola";
            this.metroTileItem9.TitleTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // timerHora
            // 
            this.timerHora.Tick += new System.EventHandler(this.timerHora_Tick);
            // 
            // FrmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.metroTilePanel2);
            this.Controls.Add(this.lblMenuPrincipal);
            this.Controls.Add(this.metroTilePanel1);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.lblNomUsu);
            this.Controls.Add(this.MenuOpciones);
            this.DoubleBuffered = true;
            this.Name = "FrmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EASY REST";
            this.Load += new System.EventHandler(this.FrmMenuPrincipal_Load_1);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.RadialMenu MenuOpciones;
        private DevComponents.DotNetBar.RadialMenuItem ItemPerfil;
        private DevComponents.DotNetBar.RadialMenuItem ItemIdioma;
        private DevComponents.DotNetBar.RadialMenuItem ItemSesion;
        private DevComponents.DotNetBar.RadialMenuItem radialMenuItem1;
        private DevComponents.DotNetBar.LabelX lblNomUsu;
        private DevComponents.DotNetBar.LabelX lblHora;
        private DevComponents.DotNetBar.Metro.MetroTilePanel metroTilePanel1;
        private DevComponents.DotNetBar.ItemContainer itemContainer1;
        private DevComponents.DotNetBar.Metro.MetroTileItem itemSalas;
        private DevComponents.DotNetBar.Metro.MetroTileItem metroTileItem2;
        private DevComponents.DotNetBar.Metro.MetroTileItem metroTileItem3;
        private DevComponents.DotNetBar.Metro.MetroTileItem metroTileItem4;
        private DevComponents.DotNetBar.Metro.MetroTileItem metroTileItem5;
        private DevComponents.DotNetBar.LabelX lblMenuPrincipal;
        private DevComponents.DotNetBar.Metro.MetroTilePanel metroTilePanel2;
        private DevComponents.DotNetBar.ItemContainer itemContainer2;
        private DevComponents.DotNetBar.Metro.MetroTileItem metroTileItem1;
        private DevComponents.DotNetBar.Metro.MetroTileItem metroTileItem6;
        private DevComponents.DotNetBar.Metro.MetroTileItem metroTileItem7;
        private DevComponents.DotNetBar.Metro.MetroTileItem metroTileItem8;
        private DevComponents.DotNetBar.Metro.MetroTileItem metroTileItem9;
        private System.Windows.Forms.Timer timerHora;
    }
}

