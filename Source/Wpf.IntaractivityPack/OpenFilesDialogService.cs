using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace Wpf
{
   public  class OpenFilesDialogService : FileDialogService, IOpenFilesDialogService
    {
        /// <summary>
        /// ファイル ダイアログで選択されたファイルの完全なパスを含む文字列を取得または設定します。
        /// </summary>
        public string[] FileNames { get; set; }
        /// <summary>
        /// 選択されたファイルのファイル名のみを格納する文字列を取得します。
        /// </summary>
        /// <remarks>
        /// 選択されたファイルのファイル名のみを格納する String。 既定値は Empty です。ファイルが選択されていない場合やディレクトリが選択された場合もこの値が使用されます。
        /// </remarks>
        public string[] SafeFileNames { get; set; }

        public override bool ShowDialog()
        {
            var dialog = new OpenFileDialog
            {
                AddExtension = AddExtension,
                CheckFileExists = CheckFileExists,
                CheckPathExists = CheckPathExists,
                CustomPlaces = CustomPlaces,
                DefaultExt = DefaultExt,
                DereferenceLinks = DereferenceLinks,
                Filter = Filter,
                FilterIndex = FilterIndex,
                InitialDirectory = InitialDirectory,
                //ShowReadOnly = ShowReadOnly,
                Tag = Tag,
                Title = Title,
                ValidateNames = ValidateNames,
                Multiselect = true
            };
            var result = dialog.ShowDialog();

            FileNames = dialog.FileNames;
            SafeFileNames = dialog.SafeFileNames;

            return result != null && (bool)result;
        }
    }
}
