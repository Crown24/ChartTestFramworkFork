using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChartTestFramwork
{
    internal class ControllerEKG : IControllerEKG
    {
        private IModelECGDevice modelEKGDevice;
        private IModelLocalData modelLocalData;
        private IViewEKG viewEKG;
        private bool liveSave=false;
        IViewEKG IControllerEKG.ViewEKG { set => viewEKG=value; }
        IModelECGDevice IControllerEKG.ModelEKGDevice { set => modelEKGDevice=value; }
        IModelLocalData IControllerEKG.ModelLocaldata { set => modelLocalData=value; }

        void IControllerEKG.getData24h()
        {
            viewEKG.Data24h=modelLocalData.getData24h();
        }

        void IControllerEKG.saveLiveData()
        {
            liveSave=true;
            while (liveSave == true)
            {
                ECGValue aktuellerWert = new ECGValue();
                aktuellerWert.TimeStamp = DateTime.Now;
                aktuellerWert.Value = modelEKGDevice.getValue();
                modelLocalData.saveLiveData(aktuellerWert);
                Application.DoEvents();
            }
        }

        void IControllerEKG.saveSQL()
        {
            liveSave = true;
            while (liveSave == true)
            {
                ECGValue aktuellerWert = new ECGValue();
                aktuellerWert.TimeStamp = DateTime.Now;
                aktuellerWert.Value = modelEKGDevice.getValue();
                modelLocalData.saveLiveData(aktuellerWert);
                Application.DoEvents();
                modelEKGDevice.saveSQL(aktuellerWert);
            }
            
        }

        void IControllerEKG.startLiveData()
        {
           modelEKGDevice.startLiveData();
        }

        void IControllerEKG.stopLiveData()
        {
            modelEKGDevice.stopLiveData();
        }

        void IControllerEKG.stopSaveLiveData()
        {
            this.liveSave=false;
        }




    }
}
