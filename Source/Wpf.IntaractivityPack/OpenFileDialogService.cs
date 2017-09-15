using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.Win32;

namespace Wpf
{
    public class OpenFileDialogService : IOpenFileDialogService
    {
        /// <summary>
        /// ユーザーが拡張子を省略した場合に、ファイル ダイアログで自動的にファイル名に拡張子を付けるかどうかを示す値を取得または設定します。
        /// </summary>
        /// <remarks>
        /// 拡張子を付ける場合は true。それ以外の場合は false。 既定値は、true です。
        /// </remarks>
        public bool AddExtension { get; set; } = true;
        /// <summary>
        /// ファイル ダイアログで選択されたファイルの完全なパスを含む文字列を取得または設定します。
        /// </summary>
        public string FileName { get; set; }

        public bool ShowDialog()
        {
            var dialog = new OpenFileDialog();
            var result = dialog.ShowDialog();

            FileName = dialog.FileName;

            return result != null && (bool) result;
        }
    }
}
