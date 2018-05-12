using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilityBill
{
    public enum Privileges { noPrivileges, labourVeteran, WarVeteran }
    public class Humans
    {
        public Humans(int _heatingTariff = 30, int _waterTariff = 20, int _gasTariff = 15, int _repairTariff = 25)
        {
            privileges = Privileges.noPrivileges;
            gasTariff = _gasTariff;
            heatingTariff = _heatingTariff;
            waterTariff = _waterTariff;
            repairTariff = _repairTariff;
        }
        public Humans(Privileges l, int _heatingTariff = 20, int _waterTariff = 16, int _gasTariff = 15, int _repairTariff = 25)
        {
            privileges = l;
            gasTariff = _gasTariff;
            heatingTariff = _heatingTariff;
            waterTariff = _waterTariff;
            repairTariff = _repairTariff;
        }
        public Privileges privileges { get; set; }

        private int heatingTariff_;
        public int heatingTariff
        {
            get
            {
                return heatingTariff_;
            }
            set
            {
                heatingTariff_ = value;

                if (privileges == Privileges.labourVeteran)
                {
                    heatingTariff_ = (value / 10) * 7;
                }
                else if (privileges == Privileges.WarVeteran)
                {
                    heatingTariff_ = (value / 10) * 5;
                }
                else
                {
                    heatingTariff_ = value;
                }
            }
        }
        private int waterTariff_;
        public int waterTariff
        {
            get
            {
                return waterTariff_;
            }
            set
            {
                waterTariff_ = value;
                if (privileges == Privileges.labourVeteran)
                {
                    waterTariff_ = (value / 10) * 7;
                }
                else if (privileges == Privileges.WarVeteran)
                {
                    waterTariff_ = (value / 10) * 5;
                }
                else
                {
                    waterTariff_ = value;
                }
            }
        }
        private int gasTariff_;
        public int gasTariff
        {
            get
            {
                return gasTariff_;
            }
            set
            {
                gasTariff_ = value;
                if (privileges == Privileges.labourVeteran)
                {
                    gasTariff_ = (value / 10) * 7;
                }
                else if (privileges == Privileges.WarVeteran)
                {
                    gasTariff_ = (value / 10) * 5;
                }
                else
                {
                    gasTariff_ = value;
                }
            }
        }
        private int repairTariff_;
        public int repairTariff
        {
            get
            {
                return repairTariff_;
            }
            set
            {
                repairTariff_ = value;
                if (privileges == Privileges.labourVeteran)
                {
                    repairTariff_ = (value / 10) * 7;
                }
                else if (privileges == Privileges.WarVeteran)
                {
                    repairTariff_ = (value / 10) * 5;
                }
                else
                {
                    repairTariff_ = value;
                }
            }
        }

    }
}
