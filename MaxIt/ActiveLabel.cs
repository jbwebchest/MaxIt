using System.ComponentModel;
using System.Drawing.Design;
using static MaxIt.Enumerations;

namespace MaxIt
{
    public class ActiveLabel : Label
    {
        private LabelRole _role = LabelRole.Label;
        private string _id = string.Empty;
        private string _hint = string.Empty;
        private int? _value;
        private List<string>? _captions;
        private List<string>? _hints;
        private List<int>? _values;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [Editor("System.Windows.Forms.Design.ListControlStringCollectionEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        [Localizable(true)]
        public List<string>? Captions
        {
            get
            {
                _captions ??= new();

                return _captions;
            }
            set => _captions = value;
        }

        public LabelRole Role 
        { 
            get => _role; 
            set => _role = value; 
        }
        
        public string Id 
        { 
            get => _id; 
            set => _id = value; 
        }

        public string Hint 
        { 
            get => _hint; 
            set => _hint = value; 
        }
        
        public int? Value 
        { 
            get => _value; 
            set => _value = value; 
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [Editor("System.Windows.Forms.Design.ListControlStringCollectionEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        [Localizable(true)]
        public List<string>? Hints
        {
            get
            {
                _hints ??= new();
                return _hints;
            }
            set => _hints = value;
        }

        public List<int>? Values 
        {
            get
            {
                _values ??= new();
                return _values;
            }
            set => _values = value; 
        }

        public ActiveLabel() 
        {
            Role = LabelRole.Label;
            Id = Name;
            Hint = string.Empty;
        }


    }
}
