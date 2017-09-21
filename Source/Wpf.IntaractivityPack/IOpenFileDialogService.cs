using System.Collections.Generic;
using System.Windows;
using Microsoft.Win32;

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
        /// 存在しないファイル名をユーザーが指定した場合に、ファイル ダイアログで警告を表示するかどうかを示す値を取得または設定します。
        /// </summary>
        /// <remarks>
        /// 警告を表示する場合は true。それ以外の場合は false。 この基本クラスの既定値は true です。
        /// </remarks>
        bool CheckFileExists { get; set; }

        /// <summary>
        /// ユーザーが無効なパスとファイル名を入力した場合に警告を表示するかどうかを指定する値を取得または設定します。
        /// </summary>
        /// <remarks>
        /// 警告を表示する場合は true。それ以外の場合は false。 既定値は、true です。
        /// </remarks>
        bool CheckPathExists { get; set; }

        /// <summary>
        /// ファイル ダイアログ ボックスのカスタム プレースのリストを取得または設定します。
        /// </summary>
        IList<FileDialogCustomPlace> CustomPlaces { get; set; }

        /// <summary>
        /// 表示されるファイル リストにフィルターを適用するための既定の拡張子文字列を指定する値を取得または設定します。
        /// </summary>
        /// <remarks>
        /// 既定の拡張子文字列。 既定値は、Empty です。
        /// </remarks>
        string DefaultExt { get; set; }

        /// <summary>
        /// ファイル ダイアログが、ショートカットで参照されたファイルの場所を返すか、ショートカット ファイル (.lnk) の場所を返すかを示す値を取得または設定します。
        /// </summary>
        /// <remarks>
        /// 参照先の場所を返す場合は true。ショートカットの場所を返す場合は false。 既定値は、false です。
        /// </remarks>
        bool DereferenceLinks { get; set; }

        /// <summary>
        /// ファイル ダイアログで選択されたファイルの完全なパスを含む文字列を取得または設定します。
        /// </summary>
        string FileName { get; set; }

        /// <summary>
        /// OpenFileDialog または SaveFileDialog で表示されるファイルの種類を決定するフィルター文字列を取得または設定します。
        /// </summary>
        /// <remarks>
        /// フィルターを格納している String。 既定値は Empty です。これは、フィルターが適用されず、すべてのファイルの種類が表示されることを意味します。
        /// </remarks>
        string Filter { get; set; }

        /// <summary>
        /// ファイル ダイアログで現在選択されているフィルターのインデックスを取得または設定します。
        /// </summary>
        /// <remarks>
        /// 選択されたフィルターのインデックスである Int32。 既定値は 1 です。
        /// </remarks>
        int FilterIndex { get; set; }

        /// <summary>
        /// ファイル ダイアログに表示される初期ディレクトリを取得または設定します。
        /// </summary>
        /// <remarks>
        /// 初期ディレクトリを格納している String。 既定値は、Empty です。
        /// </remarks>
        string InitialDirectory { get; set; }

        /// <summary>
        /// 選択されたファイルのファイル名のみを格納する文字列を取得します。
        /// </summary>
        /// <remarks>
        /// 選択されたファイルのファイル名のみを格納する String。 既定値は Empty です。ファイルが選択されていない場合やディレクトリが選択された場合もこの値が使用されます。
        /// </remarks>
        string SafeFileName { get; set; }

        ///// <summary>
        ///// OpenFileDialogに読み取り専用チェックボックスが含まれているかどうかを示す値を取得または設定します。
        ///// </summary>
        ///// <remarks>
        ///// チェックボックスが表示する場合はtrue、 それ以外の場合はfalseです。
        ///// </remarks>
        //bool ShowReadOnly { get; set; }

        /// <summary>
        /// ダイアログに関連付けられたオブジェクトを取得または設定します。これは、ダイアログ ボックスに、任意のオブジェクトをアタッチできる機能を提供します。
        /// </summary>
        object Tag { get; set; }

        /// <summary>
        /// ファイル ダイアログのタイトル バーに表示されるテキストを取得または設定します。
        /// </summary>
        /// <remarks>
        /// ファイル ダイアログのタイトル バーに表示されるテキストである String。 既定値は、Empty です。
        /// </remarks>
        string Title { get; set; }

        /// <summary>
        /// ダイアログが有効な Win32 ファイル名だけを受け入れるかどうかを示す値を取得または設定します。
        /// </summary>
        /// <remarks>
        /// 無効なファイル名が入力されたときに警告を表示する場合は true。それ以外の場合は false。 既定値は、false です。
        /// </remarks>
        bool ValidateNames { get; set; }

        bool ShowDialog();
    }
}