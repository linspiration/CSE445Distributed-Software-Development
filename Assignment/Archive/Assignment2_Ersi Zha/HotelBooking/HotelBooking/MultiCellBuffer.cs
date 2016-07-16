using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace HotelBooking
{
    public class MultiCellBuffer
    {
        private String[] bufferCell;
        private bool[] writeable;
        private Semaphore semaphore;
        public MultiCellBuffer()
        {
            bufferCell = new String[2];
            writeable = new bool[2];
            semaphore = new Semaphore(2, 2);
            //intitializae MutiCellBuffer
            for (int i = 0; i < 2; i++)
            {
                writeable[i] = true;
                bufferCell[i] = "";
            }
        }
        //Iterate the buffercell and check if there are no readable buffercells
        private Boolean noReadableCells()
        {
            bool noReadable = true;
            for (int i = 0; i < bufferCell.Length; i++)
            {
                if (!writeable[i])
                {
                    noReadable = false;
                    break;
                }
            }
            return noReadable;
        }
        public String getOneCell()
        {
            String Data = "";
            semaphore.WaitOne();
            lock(this){
            for (int i = 0; i < bufferCell.Length; i++)
            {
                while (noReadableCells()) Monitor.Wait(this);
                if (!writeable[i])
                {
                    Data = bufferCell[i];
                    writeable[i] = true;
                    break;
                }
            }
            Monitor.Pulse(this);
        }
            semaphore.Release();
            return Data;
        }
        //Iterate the buffercell and check if there are no writeable buffercells
        private Boolean noWriteableCells()
        {
            Boolean noWriteable = true;

            for (int i = 0; i < bufferCell.Length; i++)
            {
                if (writeable[i])
                {
                    noWriteable = false;
                    break;
                }
            }
            return noWriteable;
        }
        public void setOneCell(String Data)
        {
            for (int i = 0; i < bufferCell.Length; i++)
            {
                semaphore.WaitOne();
            lock(this){
                while (!writeable[i]) Monitor.Wait(this);
                if (writeable[i]) 
                {
                    bufferCell[i] = Data;
                    writeable[i]= false;
                    break;
                }
            }
            Monitor.Pulse(this);
        }
            semaphore.Release();       
        }
    }
}
