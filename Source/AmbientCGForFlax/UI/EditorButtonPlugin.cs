using System;
using System.IO;
using System.Collections.Generic;
using FlaxEngine;
using FlaxEditor;
using FlaxEditor.GUI.ContextMenu;
using FlaxEditor.CustomEditors;
using FlaxEditor.CustomEditors.Elements;
using FlaxEditor.Content.Import;

namespace AmbientCGForFlax
{
    public class AmbientCGForFlaxEditorButton : EditorPlugin
    {
        private const string ButtonText = "AmbientCG For Flax";

        private ContextMenuButton _btn = null;

        public override void InitializeEditor()
        {
            _description = new PluginDescription
            {
                Name = "AmbientCG For Flax",
                Description = "TODO",
                Author = "Navis",
                Category = "Graphics",
                Version = new Version(0, 1),
            };

            base.InitializeEditor();

            _btn = Editor.Instance.UI.MenuWindow.ContextMenu.AddButton(ButtonText);
            _btn.ButtonClicked += OnButtonClicked;
        }

        public override void DeinitializeEditor()
        {
            _btn?.Dispose();
            _btn = null;

            base.DeinitializeEditor();
        }

        private void OnButtonClicked(ContextMenuButton btn)
        {
            Curl.DownloadToCache("https://cdn3.struffelproductions.com/file/ambientCG/media/sphere/128-JPG-FFFFFF/WoodFloor051_PREVIEW.jpg", "WoodFloor051_PREVIEW.jpg");

            var tex = Content.CreateVirtualAsset<Texture>();
            tex.LoadFile(@"C:\Users\Cristhofer\Documents\_Projects\AmbientCGForFlax\Cache\WoodFloor051_PREVIEW.jpg");
            tex.WaitForLoaded();
            Debug.Log(tex.LastLoadFailed);
            Debug.Log(tex.Width);

            // TextureImportSettings settings = new TextureImportSettings();
            // settings.Type = TextureImportSettings.CustomTextureFormatType.ColorRGB;

            // Editor.Import(@"C:\Users\Cristhofer\Documents\_Projects\AmbientCGForFlax\Cache\WoodFloor051_PREVIEW.jpg", Path.Combine(Editor.Instance.GameProject.ProjectFolderPath, "Content", "WoodFloor051_PREVIEW.jpg"));

            // string[] lines = Curl.Download("https://ambientcg.com/api/v2/downloads_csv?type=Material&q=Wood").Split('\n');

            // foreach(string line in lines)
            // {
            //     Debug.Log(line);
            // }
        }
    }
}
//https://ambientcg.com/api/v2/full_json?include=previewData
