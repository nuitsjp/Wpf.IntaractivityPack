namespace Wpf
{
    public interface IOpenFilesDialogService : IFileDialogService
    {
        /// <summary>
        /// ファイル ダイアログで選択されたファイルの完全なパスを含む文字列を取得または設定します。
        /// </summary>
        string[] FileNames { get; set; }

        /// <summary>
        /// 選択されたファイルのファイル名のみを格納する文字列を取得します。
        /// </summary>
        /// <remarks>
        /// 選択されたファイルのファイル名のみを格納する String。 既定値は Empty です。ファイルが選択されていない場合やディレクトリが選択された場合もこの値が使用されます。
        /// </remarks>
        string[] SafeFileNames { get; set; }

    }
}