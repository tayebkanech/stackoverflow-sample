using CefSharp;
using CefSharp.Wpf;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows;

namespace CefSharpWpfDemo
{
	/// <summary>
	/// MainWindow.xaml에 대한 상호 작용 논리
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();

			Loaded += MainWindow_Loaded;
		}

		private void MainWindow_Loaded(object sender, RoutedEventArgs e)
		{

			var assembly = Assembly.GetExecutingAssembly();
			var resourceName = $"CefSharpWpfDemo.Index.html";

			using (Stream stream = assembly.GetManifestResourceStream(resourceName))
			using (StreamReader reader = new StreamReader(stream, Encoding.Default))
			{
				string html = reader.ReadToEnd();
				browser.LoadHtml(html);
			}
			InitializeChromeBrowser();
		}

		private void InitializeChromeBrowser()
		{
			CefSharpSettings.LegacyJavascriptBindingEnabled = true;
			browser.RegisterAsyncJsObject("boundAsync", new ChromeAPI());
		}
	}

	internal class ChromeAPI
	{
		public void showMsg(string msg) 
		{ 
			MessageBox.Show(msg); 
		}
	}

}
