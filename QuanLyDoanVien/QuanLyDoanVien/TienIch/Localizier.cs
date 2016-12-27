﻿using DevExpress.XtraBars.Docking2010;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Localization;
using DevExpress.XtraPivotGrid.Localization;

namespace QuanLyDoanVien.TienIch
{
    public class VietNamDocumentManagerLocalizer : DocumentManagerLocalizer
    {
        public override string Language
        {
            get { return "Vietnam"; }
        }

        public override string GetLocalizedString(DocumentManagerStringId id)
        {
            switch (id)
            {
                case DocumentManagerStringId.CommandClose:
                    return "Đóng";
                case DocumentManagerStringId.CommandCloseAll:
                    return "Đóng tất cả";
                case DocumentManagerStringId.CommandActivate:
                    return "Sửa dụng";
            }
            return base.GetLocalizedString(id);
        }
    }

    public class VietNamGridLocalizer : GridLocalizer
    {
        public override string Language
        {
            get { return "Vietnam"; }
        }

        public override string GetLocalizedString(GridStringId id)
        {
            switch (id)
            {
                case GridStringId.MenuColumnSortAscending:
                    return "Sắp xếp tăng";
                case GridStringId.MenuColumnSortDescending:
                    return "Sắp xếp giảm";
                case GridStringId.MenuColumnClearSorting:
                    return "Không sắp xếp";
                case GridStringId.MenuColumnGroup:
                    return "Nhóm cột";
                case GridStringId.MenuColumnUnGroup:
                    return "Không nhóm";
                case GridStringId.MenuColumnGroupBox:
                    return "Hiện thị cột được nhóm";
                case GridStringId.MenuColumnColumnCustomization:
                    return "Quản lý";
                case GridStringId.MenuColumnFilterEditor:
                    return "Tùy chọn lọc dữ liệu";
                case GridStringId.MenuColumnBestFit:
                    return "Tự động co giãn";
                case GridStringId.MenuColumnFilter:
                    return "Lọc dữ liệu";
                case GridStringId.MenuColumnClearFilter:
                    return "Không lọc dữ liệu";
                case GridStringId.MenuColumnBestFitAllColumns:
                    return "Tự động co giãn tất cả";
                case GridStringId.MenuColumnRemoveColumn:
                    return "Ẩn cột này";
                case GridStringId.MenuColumnAutoFilterRowShow:
                    return "Hiện chế độ lọc dữ liệu";
                case GridStringId.MenuColumnAutoFilterRowHide:
                    return "Ẩn chế độ lọc dữ liệu";
                case GridStringId.MenuGroupPanelShow:
                    return "Hiện nhóm";
                case GridStringId.MenuGroupPanelHide:
                    return "Ẩn nhóm";
                case GridStringId.MenuGroupPanelClearGrouping:
                    return "Không nhóm";
                case GridStringId.MenuGroupPanelFullCollapse:
                    return "Thu gọn các nhóm";
                case GridStringId.MenuGroupPanelFullExpand:
                    return "Mở rộng các nhóm";

                case GridStringId.MenuColumnFilterMode:
                    return "Lọc theo dạng";
                case GridStringId.MenuColumnFilterModeDisplayText:
                    return "Văn bản hiển thị";
                case GridStringId.MenuColumnFilterModeValue:
                    return "Giá trị lưu xuống";

                case GridStringId.GridGroupPanelText:
                    return "Sử dụng chức năng nhóm cột tại đây bằng cách kéo thả một cột bất kỳ";

                case GridStringId.MenuColumnFindFilterShow:
                    return "Hiện tìm kiếm";
                case GridStringId.MenuColumnFindFilterHide:
                    return "Ẩn tìm kiếm";
                case GridStringId.FindControlClearButton:
                    return "Hủy";
                case GridStringId.FindControlFindButton:
                    return "Tìm";
                case GridStringId.FindNullPrompt:
                    return "Nhập giá trị cần tìm";


                case GridStringId.FilterBuilderCaption:
                    return "Tùy chọn lọc dữ liệu";
                case GridStringId.FilterBuilderApplyButton:
                    return "Chọn";
                case GridStringId.FilterBuilderCancelButton:
                    return "Đóng";
                case GridStringId.FilterBuilderOkButton:
                    return "Đồng ý";


                case GridStringId.MenuFooterAverage:
                    return "Trung bình";
                case GridStringId.MenuFooterCount:
                    return "Đếm";

                case GridStringId.FilterPanelCustomizeButton:
                    return "Tùy chọn lọc dữ liệu";

                case GridStringId.GridNewRowText:
                    return "Nhấn vào đây để thêm nhanh dòng mới";
                case GridStringId.CustomizationCaption:
                    return "Điều chỉnh ẩn hiện cột";
                case GridStringId.CustomizationBands:
                    return "Nhóm cột";
                case GridStringId.CustomizationColumns:
                    return "Cột";
                case GridStringId.CustomizationFormBandHint:
                    return "Kéo thả nhóm muốn ẩn vào đây";
                case GridStringId.CustomizationFormColumnHint:
                    return "Kéo thả cột muốn ẩn vào đây";

                case GridStringId.PopupFilterAll:
                    return "(Tất cả)";
                case GridStringId.PopupFilterBlanks:
                    return "(Không có dữ liệu)";
                case GridStringId.PopupFilterCustom:
                    return "(Tùy chọn...)";
                case GridStringId.PopupFilterNonBlanks:
                    return "(Có dữ liệu)";

                case GridStringId.CustomFilterDialogCaption:
                    return "Lọc dữ liệu";
            }
            return base.GetLocalizedString(id);
        }
    }


    public class VietNamEditorsLocalizer : Localizer
    {
        public override string Language
        {
            get { return "Vietnam"; }
        }

        public override string GetLocalizedString(StringId id)
        {
            switch (id)
            {
                case StringId.CalcError:
                    return "Lỗi phép tính";

                case StringId.CaptionError:
                    return "Lỗi";
                case StringId.CheckChecked:
                    return "Đánh dấu chọn";
                case StringId.CheckIndeterminate:
                    return "CheckIndeterminate";
                case StringId.CheckUnchecked:
                    return "Không đánh dấu chọn";
                case StringId.ColorTabCustom:
                    return "Điều chỉnh";
                case StringId.ColorTabSystem:
                    return "Hệ thống";
                case StringId.ColorTabWeb:
                    return "Web";
                case StringId.ContainerAccessibleEditName:
                    return "ContainerAccessibleEditName";
                case StringId.DataEmpty:
                    return "Dữ liệu trống";
                case StringId.DateEditClear:
                    return "Xóa";
                case StringId.DateEditToday:
                    return "Hôm nay";
                case StringId.FilterClauseAnyOf:
                    return "Bất kỳ của";
                case StringId.FilterClauseBeginsWith:
                    return "Bắt đầu với";
                case StringId.FilterClauseBetween:
                    return "Khoảng giữa";
                case StringId.FilterClauseBetweenAnd:
                    return "và";
                case StringId.FilterClauseContains:
                    return "Chứa";
                case StringId.FilterClauseDoesNotContain:
                    return "Không chứa";
                case StringId.FilterClauseDoesNotEqual:
                    return "Khác";
                case StringId.FilterClauseEndsWith:
                    return "Kết thúc bằng";
                case StringId.FilterClauseEquals:
                    return "Bằng";
                case StringId.FilterClauseGreater:
                    return "Lớn hơn";
                case StringId.FilterClauseGreaterOrEqual:
                    return "Lớn hơn hoặc bằng";
                case StringId.FilterClauseIsNotNull:
                    return "Khác rỗng";
                case StringId.FilterClauseIsNull:
                    return "Bằng rỗng";
                case StringId.FilterClauseLess:
                    return "Nhỏ hơn";
                case StringId.FilterClauseLessOrEqual:
                    return "Nhỏ hơn hoặc bằng";
                case StringId.FilterClauseLike:
                    return "Giống";
                case StringId.FilterClauseNoneOf:
                    return "Is none of";
                case StringId.FilterClauseNotBetween:
                    return "Nằm ngoài";
                case StringId.FilterClauseNotLike:
                    return "Không giống";


                /*FilterCriteriaToString*/
                case StringId.FilterEmptyEnter:
                    return "nhập một giá trị";
                case StringId.FilterEmptyValue:
                    return "rỗng";
                case StringId.FilterGroupAnd:
                    return "Và";
                case StringId.FilterGroupNotAnd:
                    return "Không và";
                case StringId.FilterGroupNotOr:
                    return "Không hoặc";
                case StringId.FilterGroupOr:
                    return "Hoặc";
                case StringId.FilterMenuClearAll:
                    return "Xóa tất cả";
                case StringId.FilterMenuConditionAdd:
                    return "Thêm điều kiện";
                case StringId.FilterMenuGroupAdd:
                    return "Thêm nhóm";
                case StringId.FilterMenuRowRemove:
                    return "Xóa dòng";
                case StringId.FilterToolTipElementAdd:
                    return "Thêm một phần tử vào danh sách";
                case StringId.FilterToolTipKeysAdd:
                    return "(Sử dụng phím Insert trên bàn phím)";
                case StringId.FilterToolTipKeysRemove:
                    return "(Sử dụng phím Delete trên bàn phím)";
                case StringId.FilterToolTipNodeAction:
                    return "Hành động";
                case StringId.FilterToolTipNodeAdd:
                    return "Thêm mới điều kiện vào nhóm";
                case StringId.FilterToolTipNodeRemove:
                    return "Bỏ điều kiện này";
                case StringId.FilterToolTipValueType:
                    return "So sánh với một giá trị";

                case StringId.ImagePopupEmpty:
                    return "(Rỗng)";
                case StringId.ImagePopupPicture:
                    return "(Ảnh)";
                case StringId.InvalidValueText:
                    return "Giá trị không hợp lệ";
                case StringId.LookUpColumnDefaultName:
                    return "Tên";
                case StringId.LookUpEditValueIsNull:
                    return "";
                //case StringId.LookUpInvalidEditValueType
                case StringId.MaskBoxValidateError:
                    return
                        "Giá trị nhập vào chưa đúng. Bạn có muốn chỉnh sửa nó không?\r\n\r\nĐồng ý - quay lại editor và chỉnh sửa.\r\nKhông đồng ý - giữ nguyên giá trị.\r\nHủy - trở về giá trị trước khi sửa.\r\n ";

                case StringId.NavigatorTextStringFormat:
                    return "Dòng {0} của {1}";
                case StringId.NavigatorAppendButtonHint:
                    return "Thêm";
                case StringId.NavigatorCancelEditButtonHint:
                    return "Không lưu";
                case StringId.NavigatorEditButtonHint:
                    return "Sửa";
                case StringId.NavigatorRemoveButtonHint:
                    return "Xóa";
                case StringId.NavigatorEndEditButtonHint:
                    return "Lưu";
                case StringId.NavigatorFirstButtonHint:
                    return "Dòng đầu";
                case StringId.NavigatorLastButtonHint:
                    return "Dòng cuối";
                case StringId.NavigatorNextButtonHint:
                    return "Dòng kế";
                case StringId.NavigatorPreviousButtonHint:
                    return "Dòng trước";
                case StringId.NavigatorNextPageButtonHint:
                    return "Trang kế";
                case StringId.NavigatorPreviousPageButtonHint:
                    return "Trang trước";
                //case StringId.NotValidArrayLength
                case StringId.PictureEditMenuCut:
                    return "Cắt";
                case StringId.PictureEditMenuCopy:
                    return "Sao lưu";
                case StringId.PictureEditMenuPaste:
                    return "Dán";
                case StringId.PictureEditMenuDelete:
                    return "Xóa";
                case StringId.PictureEditMenuLoad:
                    return "Chọn ảnh ...";

                case StringId.PictureEditMenuSave:
                    return "Lưu";
                case StringId.PictureEditOpenFileError:
                    return "Định dạng ảnh sai";
                case StringId.PictureEditOpenFileErrorCaption:
                    return "Lỗi mở ảnh";
                case StringId.PictureEditOpenFileFilter:
                    return
                        "Bitmap Files (*.bmp)|*.bmp|Graphics Interchange Format (*.gif)|*.gif|JPEG" +
                        " File Interchange Format (*.jpg;*.jpeg)|*.jpg;*.jpeg|Icon Files (*.ico)|*.ico|All" +
                        " Picture Files |*.bmp;*.gif;*.jpg;*.jpeg;*.ico;*.png;*.tif|All Files |*.*";
                case StringId.PictureEditOpenFileTitle:
                    return "Nạp hình";
                //case StringId.PictureEditSaveFileFilter
                case StringId.PictureEditSaveFileTitle:
                    return "Lưu mới";


                case StringId.TabHeaderButtonClose:
                    return "Đóng";
                case StringId.TabHeaderButtonNext:
                    return "Kế";
                case StringId.TabHeaderButtonPrev:
                    return "Trước";

                case StringId.TextEditMenuCopy:
                    return "Sao lưu";
                case StringId.TextEditMenuCut:
                    return "Cắt";
                case StringId.TextEditMenuPaste:
                    return "Dán";
                case StringId.TextEditMenuDelete:
                    return "Xóa";
                case StringId.TextEditMenuSelectAll:
                    return "Chọn tất cả";
                case StringId.TextEditMenuUndo:
                    return "Quay lại";

                case StringId.UnknownPictureFormat:
                    return "Không hiểu định dạng tập tin hình ảnh";

                case StringId.OK:
                    return "Đồng ý";
                case StringId.Cancel:
                    return "Đóng";

                case StringId.XtraMessageBoxAbortButtonText:
                    return "Cảnh báo";
                case StringId.XtraMessageBoxCancelButtonText:
                    return "Quay lại";
                case StringId.XtraMessageBoxIgnoreButtonText:
                    return "Bỏ qua";
                case StringId.XtraMessageBoxNoButtonText:
                    return "Không";
                case StringId.XtraMessageBoxOkButtonText:
                    return "Đồng ý";
                case StringId.XtraMessageBoxRetryButtonText:
                    return "Thử lại";
                case StringId.XtraMessageBoxYesButtonText:
                    return "Có";
                // ...
            }
            return base.GetLocalizedString(id);
        }
    }

    public class VietNamPivotGridLocalizer : PivotGridLocalizer
    {
        public override string Language
        {
            get { return "Vietnam"; }
        }

        public override string GetLocalizedString(PivotGridStringId id)
        {
            switch (id)
            {
                case PivotGridStringId.TotalFormat:
                    return "Tổng {0}";
                case PivotGridStringId.GrandTotal:
                    return "Tổng";
                case PivotGridStringId.PopupMenuSortFieldByColumn:
                    return "Sắp xếp theo cột '{0}'";
                case PivotGridStringId.PopupMenuRemoveAllSortByColumn:
                    return "Không sắp xếp";
                case PivotGridStringId.PopupMenuRefreshData:
                    return "Nạp lại";
                case PivotGridStringId.PopupMenuHideField:
                    return "Ẩn";
                case PivotGridStringId.PopupMenuFieldOrder:
                    return "Chỉnh vị trí";
                case PivotGridStringId.PopupMenuMovetoBeginning:
                    return "Chuyển lên đầu";
                case PivotGridStringId.PopupMenuMovetoEnd:
                    return "Chuyển ra sau";
                case PivotGridStringId.PopupMenuMovetoLeft:
                    return "Chuyển sang trái";
                case PivotGridStringId.PopupMenuMovetoRight:
                    return "Chuyển sang phải";
                case PivotGridStringId.PopupMenuShowFieldList:
                    return "Hiện danh sách cột";
                case PivotGridStringId.PopupMenuShowPrefilter:
                    return "Hiện lọc dữ liệu";
                case PivotGridStringId.EditPrefilter:
                    return "Tùy chọn lọc dữ liệu";

                case PivotGridStringId.PopupMenuSortFieldByRow:
                    return "Sắp xếp theo dòng '{0}'";
                case PivotGridStringId.PopupMenuExpand:
                    return "Xổ ra";
                case PivotGridStringId.PopupMenuExpandAll:
                    return "Xổ tất cả";
                case PivotGridStringId.PopupMenuCollapse:
                    return "Thu vào";
                case PivotGridStringId.PopupMenuCollapseAll:
                    return "Thu tất cả";
            }
            return base.GetLocalizedString(id);
        }
    }
}