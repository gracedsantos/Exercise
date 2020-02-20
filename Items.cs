using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkechersCode
{

    public class Items
    {

        private string _itemType;
        private string _apendage;
        private Boolean _bark;
        private string _color;
        private string _leaves;
        private string _legs;
        private Boolean _root;
        private Boolean _stem;
        private string _taste;
        private Dictionary<string, object> _dictItems;


        #region " Properties "

        public String apendage {
            get { return _apendage;  }
            set
            {
                _apendage = value;
                _dictItems.Add("apendage", _apendage.Trim());
            }
        }
        public Boolean bark
        {
            get { return _bark; }
            set
            {
                _bark = value;
                _dictItems.Add("bark", _bark);
            }
        }

        public String color {
            get { return _color; }
            set
            {
                _color = value;
                _dictItems.Add("color", _color.Trim());
            }
        }

        public String leaves {
            get { return _leaves; }
            set
            {
                _leaves = value;
                _dictItems.Add("leaves", _leaves.Trim());
            }
        }

        public String legs {
            get { return _legs; }
            set
            {
                _legs = value;
                _dictItems.Add("legs", _legs.Trim());
            }
        }

        public Boolean root {
            get { return _root; }
            set
            {
                _root = value;
                _dictItems.Add("root", _root);
            }
        }

        public Boolean stem {
            get { return _stem; }
            set
            {
                _stem = value;
                _dictItems.Add("stem", _stem);
            }
        }
        public String taste {
            get { return _taste; }
            set
            {
                _taste = value;
                _dictItems.Add("taste", _taste.Trim());
            }
        }

        public string Key { get; set; }
        public string Value { get; set; }

        #endregion 


        public Items(string ItemType)
        {
            _itemType = ItemType;
            _dictItems = new Dictionary<string, object>();                        
        }


        private void SetResults()
        {
            _dictItems = _dictItems.OrderByDescending(i => i.Key).ToDictionary(z => z.Key, y => y.Value);    
            this.Key = _dictItems.Keys.ElementAt(0).ToString();
            this.Value = _dictItems[this.Key].ToString();             
        }

        public override string ToString()
        {
            SetResults();
            return _itemType.Trim() + "-(" + this.Key + ":" + this.Value.ToString() + ")";
        }
    }
    
}

