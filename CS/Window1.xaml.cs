using System.Collections.ObjectModel;
using System.Windows;

namespace PieDonut2DChart {
    public partial class Window1 : Window {
        public Window1() {
            InitializeComponent();
        }
    }
    public class ChartViewModel {
        public Collection<DataPoint> Data { get; private set; }
        public ChartViewModel() {
            Data = new Collection<DataPoint> {
                        new DataPoint ("Bikes", 142345),
                        new DataPoint ("Accessories", 266344),
                        new DataPoint ("Components", 631359),
                        new DataPoint ("Clothing", 120007)
            };
        }
        public class DataPoint {
            public string Argument { get; private set; }
            public double Value { get; private set; }
            public DataPoint(string argument, double value) {
                Argument = argument;
                Value = value;
            }
        }
    }
}


