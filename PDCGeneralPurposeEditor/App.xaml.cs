using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using PDCGeneralPurposeEditor.View;
using Prism.Mvvm;
using Unity;

//https://blog.okazuki.jp/entry/2016/07/16/221431を参考にしている
namespace PDCGeneralPurposeEditor
{
    /// <summary>
    /// App.xaml の相互作用ロジック
    /// </summary>
    public partial class App : Application
    {
        //アプリで管理するコンテナ
        private IUnityContainer Container { get; }=new UnityContainer();

        private void Application_Startup(object sender, StartupEventArgs e)
        {
            ViewModelLocationProvider.SetDefaultViewModelFactory(x=>this.Container.Resolve(x));
            this.Container.Resolve<MainWindow>().Show();
        }
    }
}
