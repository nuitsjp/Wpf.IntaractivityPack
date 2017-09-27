using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace Wpf
{
    public abstract class FileDialogService : IFileDialogService
    {
        #region Properties
        /// <summary>
        /// ユーザーが拡張子を省略した場合に、ファイル ダイアログで自動的にファイル名に拡張子を付けるかどうかを示す値を取得または設定します。
        /// </summary>
        /// <remarks>
        /// 拡張子を付ける場合は true。それ以外の場合は false。 既定値は、true です。
        /// </remarks>
        public bool AddExtension { get; set; } = true;

        /// <summary>
        /// 存在しないファイル名をユーザーが指定した場合に、ファイル ダイアログで警告を表示するかどうかを示す値を取得または設定します。
        /// </summary>
        /// <remarks>
        /// 警告を表示する場合は true。それ以外の場合は false。 この基本クラスの既定値は true です。
        /// </remarks>
        public bool CheckFileExists { get; set; } = true;

        /// <summary>
        /// ユーザーが無効なパスとファイル名を入力した場合に警告を表示するかどうかを指定する値を取得または設定します。
        /// </summary>
        /// <remarks>
        /// 警告を表示する場合は true。それ以外の場合は false。 既定値は、true です。
        /// </remarks>
        public bool CheckPathExists { get; set; }

        /// <summary>
        /// ファイル ダイアログ ボックスのカスタム プレースのリストを取得または設定します。
        /// </summary>
        public IList<FileDialogCustomPlace> CustomPlaces { get; set; } = new List<FileDialogCustomPlace>();

        /// <summary>
        /// 表示されるファイル リストにフィルターを適用するための既定の拡張子文字列を指定する値を取得または設定します。
        /// </summary>
        /// <remarks>
        /// 既定の拡張子文字列。 既定値は、Empty です。
        /// </remarks>
        public string DefaultExt { get; set; } = string.Empty;

        /// <summary>
        /// ファイル ダイアログが、ショートカットで参照されたファイルの場所を返すか、ショートカット ファイル (.lnk) の場所を返すかを示す値を取得または設定します。
        /// </summary>
        /// <remarks>
        /// 参照先の場所を返す場合は true。ショートカットの場所を返す場合は false。 既定値は、false です。
        /// </remarks>
        public bool DereferenceLinks { get; set; } = false;

        /// <summary>
        /// OpenFileDialog または SaveFileDialog で表示されるファイルの種類を決定するフィルター文字列を取得または設定します。
        /// </summary>
        /// <remarks>
        /// フィルターを格納している String。 既定値は Empty です。これは、フィルターが適用されず、すべてのファイルの種類が表示されることを意味します。
        /// </remarks>
        public string Filter { get; set; } = string.Empty;

        /// <summary>
        /// ファイル ダイアログで現在選択されているフィルターのインデックスを取得または設定します。
        /// </summary>
        /// <remarks>
        /// 選択されたフィルターのインデックスである Int32。 既定値は 1 です。
        /// </remarks>
        public int FilterIndex { get; set; } = 1;

        /// <summary>
        /// ファイル ダイアログに表示される初期ディレクトリを取得または設定します。
        /// </summary>
        /// <remarks>
        /// 初期ディレクトリを格納している String。 既定値は、Empty です。
        /// </remarks>
        public string InitialDirectory { get; set; } = string.Empty;

        ///// <summary>
        ///// OpenFileDialogに読み取り専用チェックボックスが含まれているかどうかを示す値を取得または設定します。
        ///// </summary>
        ///// <remarks>
        ///// チェックボックスが表示する場合はtrue、 それ以外の場合はfalseです。
        ///// </remarks>
        //public bool ShowReadOnly { get; set; }

        /// <summary>
        /// ダイアログに関連付けられたオブジェクトを取得または設定します。これは、ダイアログ ボックスに、任意のオブジェクトをアタッチできる機能を提供します。
        /// </summary>
        public object Tag { get; set; }

        /// <summary>
        /// ファイル ダイアログのタイトル バーに表示されるテキストを取得または設定します。
        /// </summary>
        /// <remarks>
        /// ファイル ダイアログのタイトル バーに表示されるテキストである String。 既定値は、Empty です。
        /// </remarks>
        public string Title { get; set; } = string.Empty;

        /// <summary>
        /// ダイアログが有効な Win32 ファイル名だけを受け入れるかどうかを示す値を取得または設定します。
        /// </summary>
        /// <remarks>
        /// 無効なファイル名が入力されたときに警告を表示する場合は true。それ以外の場合は false。 既定値は、false です。
        /// </remarks>
        public bool ValidateNames { get; set; }

        #endregion

        public abstract bool ShowDialog();
    }
}
