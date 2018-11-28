using System;
using System.ComponentModel;
using System.Windows;
using MahApps.Metro.Controls;

namespace PDCGeneralPurposeEditor.View
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();


            //テスト用、ウィンドウ表示
            var editorWindow=new EditorWindow();
            editorWindow.Show();
        }
    }
}
