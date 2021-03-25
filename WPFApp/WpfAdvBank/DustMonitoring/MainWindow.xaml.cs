using MahApps.Metro.Controls;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml;

namespace FineDustMonitoring
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        
        private readonly string filePath = $@"{AppDomain.CurrentDomain.BaseDirectory}station_list.xls";
        private string openApiUrl = "http://apis.data.go.kr/B552584/ArpltnInforInqireSvc/getMsrstnAcctoRltmMesureDnsty?" +
                                    "serviceKey=kOsbgBOmBq5jFUqhXW9CFA2rbbSt7oOlh7QRPwz0kFOItyhgTkGXtAQsImKyCkvQOL9vjPBk94BLUMXXh4anjA%3D%3D&" +
                                    "returnType=xml&" +
                                    "numOfRows=100&" +
                                    "pageNo=1&" +
                                    "ver=1.0&" +
                                    "dataTerm=DAILY&" +
                                    "stationName=";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MetroWindow_Loaded(object sender, RoutedEventArgs e)
        {
            // xls load 
            IWorkbook workbook = null;
            ISheet sheet;
            
            using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                workbook = new HSSFWorkbook(fs);
            }
            List<string> listMeasuringStation = new List<string>();
            sheet = workbook.GetSheetAt(0);
            int rowCount = sheet.LastRowNum;
            
            try
            {
                for (int r = 0; r <= rowCount; r++)
                {
                    if (r == 0) continue;
                    listMeasuringStation.Add(sheet.GetRow(r).Cells[1].ToString());
                }
            }
            catch { }
            cboStations.ItemsSource = listMeasuringStation;
        }

        private List<FineDustInfo> lstResult;
        private void cboStations_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            lstResult = new List<FineDustInfo>();
            
            if (cboStations.SelectedItem != null)
            {
                openApiUrl = openApiUrl.Substring(0, openApiUrl.LastIndexOf("=") + 1) + cboStations.SelectedItem.ToString();
                XmlDocument xml = new XmlDocument();
                xml.Load(openApiUrl);
                XmlNodeList xmllist = xml.SelectNodes("/response/body/items/item");

                foreach (XmlNode item in xmllist)
                {
                    FineDustInfo dustInfo = new FineDustInfo()
                    {
                        DataTime = item["dataTime"].InnerText,
                        Khai = item["khaiValue"].InnerText,
                        SO2 = item["so2Value"].InnerText,
                        CO = item["coValue"].InnerText,
                        PM10 = item["pm10Value"].InnerText,
                        PM25 = item["pm25Value"].InnerText,
                        NO2 = item["no2Value"].InnerText,
                        O3 = item["o3Value"].InnerText,
                    };
                    lstResult?.Add(dustInfo);
                }
            }
            dgrFineDustInfo.ItemsSource = lstResult;
        }
    }
    public class FineDustInfo
    {
        public string DataTime { get; set; }
        public string Khai { get; set; }
        public string SO2 { get; set; }
        public string CO { get; set; }
        public string NO2 { get; set; }
        public string O3 { get; set; }
        public string PM10 { get; set; }
        public string PM25 { get; set; }
    }
}
