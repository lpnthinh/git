﻿namespace QuanLyDoanVien.NghiepVu.QLVanBan
{
    partial class FrmThongKeSoLuong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmThongKeSoLuong));
            this.gridControlCustom1 = new QuanLyDoanVien.TienIch.GridControlCustom();
            this.gridViewCustom1 = new QuanLyDoanVien.TienIch.GridViewCustom();
            ((System.ComponentModel.ISupportInitialize)(this.UOW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCustom1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCustom1)).BeginInit();
            this.SuspendLayout();
            // 
            // TB
            // 
            this.TB.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnNap, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnDong, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.TB.OptionsBar.AllowQuickCustomization = false;
            this.TB.OptionsBar.DrawDragBorder = false;
            this.TB.OptionsBar.UseWholeRow = true;
            // 
            // btnThem
            // 
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.LargeImage")));
            // 
            // btnSua
            // 
            this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.Image")));
            this.btnSua.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.LargeImage")));
            // 
            // btnXoa
            // 
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.LargeImage")));
            // 
            // btnLuu
            // 
            this.btnLuu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.ImageOptions.Image")));
            this.btnLuu.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnLuu.ImageOptions.LargeImage")));
            // 
            // btnDong
            // 
            this.btnDong.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.btnDong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDong.ImageOptions.Image")));
            this.btnDong.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDong.ImageOptions.LargeImage")));
            // 
            // btnXuatExcel
            // 
            this.btnXuatExcel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXuatExcel.ImageOptions.Image")));
            this.btnXuatExcel.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXuatExcel.ImageOptions.LargeImage")));
            // 
            // btnXemVaIn
            // 
            this.btnXemVaIn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXemVaIn.ImageOptions.Image")));
            this.btnXemVaIn.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXemVaIn.ImageOptions.LargeImage")));
            // 
            // btnNap
            // 
            this.btnNap.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNap.ImageOptions.Image")));
            this.btnNap.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnNap.ImageOptions.LargeImage")));
            // 
            // gridControlCustom1
            // 
            this.gridControlCustom1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlCustom1.Location = new System.Drawing.Point(0, 29);
            this.gridControlCustom1.MainView = this.gridViewCustom1;
            this.gridControlCustom1.MenuManager = this.BM;
            this.gridControlCustom1.Name = "gridControlCustom1";
            this.gridControlCustom1.Size = new System.Drawing.Size(584, 333);
            this.gridControlCustom1.TabIndex = 4;
            this.gridControlCustom1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewCustom1});
            // 
            // gridViewCustom1
            // 
            this.gridViewCustom1.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Blue;
            this.gridViewCustom1.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gridViewCustom1.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridViewCustom1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewCustom1.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewCustom1.AppearancePrint.HeaderPanel.Options.UseTextOptions = true;
            this.gridViewCustom1.AppearancePrint.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewCustom1.AppearancePrint.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewCustom1.FixedLineWidth = 1;
            this.gridViewCustom1.GridControl = this.gridControlCustom1;
            this.gridViewCustom1.GroupFormat = "[#image]{1} {2}";
            this.gridViewCustom1.IndicatorWidth = 40;
            this.gridViewCustom1.KeyColumn = null;
            this.gridViewCustom1.Name = "gridViewCustom1";
            this.gridViewCustom1.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridViewCustom1.OptionsDetail.EnableMasterViewMode = false;
            this.gridViewCustom1.OptionsFind.FindMode = DevExpress.XtraEditors.FindMode.Always;
            this.gridViewCustom1.OptionsSelection.CheckBoxSelectorColumnWidth = 40;
            this.gridViewCustom1.OptionsSelection.InvertSelection = true;
            this.gridViewCustom1.OptionsSelection.MultiSelect = true;
            this.gridViewCustom1.OptionsSelection.ResetSelectionClickOutsideCheckboxSelector = true;
            this.gridViewCustom1.OptionsView.EnableAppearanceEvenRow = true;
            this.gridViewCustom1.OptionsView.ShowAutoFilterRow = true;
            this.gridViewCustom1.OptionsView.ShowGroupPanel = false;
            // 
            // FrmThongKeSoLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 362);
            this.Controls.Add(this.gridControlCustom1);
            this.Name = "FrmThongKeSoLuong";
            this.Text = "Thống kê số lượng văn bản";
            this.Controls.SetChildIndex(this.gridControlCustom1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.UOW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCustom1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCustom1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TienIch.GridControlCustom gridControlCustom1;
        private TienIch.GridViewCustom gridViewCustom1;
    }
}