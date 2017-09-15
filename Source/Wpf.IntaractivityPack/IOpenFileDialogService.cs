using System.Windows;

namespace Wpf
{
    public interface IOpenFileDialogService
    {
        /// <summary>
        /// ユーザーが拡張子を省略した場合に、ファイル ダイアログで自動的にファイル名に拡張子を付けるかどうかを示す値を取得または設定します。
        /// </summary>
        /// <remarks>
        /// 拡張子を付ける場合は true。それ以外の場合は false。 既定値は、true です。
        /// </remarks>
        bool AddExtension { get; set; }
        /// <summary>
        /// ファイル ダイアログで選択されたファイルの完全なパスを含む文字列を取得または設定します。
        /// </summary>
        string FileName { get; set; }

        bool ShowDialog();
    }
}