using System;

namespace Cocos2D
{
    public class CCMenuItemFont : CCMenuItemLabel
    {
        protected string m_strFontName;
        protected uint m_uFontSize;

        public CCMenuItemFont (string value) : this(value, null)
        { }
        
		public CCMenuItemFont (string value, Action<object> selector)
        {
            InitWithString(value, selector);
        }
        
        public static uint FontSize
        {
            get { return _fontSize; }
            set { _fontSize = value; }
        }

        public static string FontName
        {
            get { return _fontName; }
            set { _fontName = value; }
        }

        public uint FontSizeObj
        {
            set
            {
                m_uFontSize = value;
                RecreateLabel();
            }
            get { return m_uFontSize; }
        }

        public string FontNameObj
        {
            set
            {
                m_strFontName = value;
                RecreateLabel();
            }
            get { return m_strFontName; }
        }

		public bool InitWithString(string value, Action<object> selector)
        {
            //CCAssert( value != NULL && strlen(value) != 0, "Value length must be greater than 0");

            m_strFontName = _fontName;
            m_uFontSize = _fontSize;

            CCLabel label = new CCLabel(value, m_strFontName, m_uFontSize);
            base.InitWithLabel(label, selector);
            return true;
        }

        protected void RecreateLabel()
        {
            CCLabel label = new CCLabel((m_pLabel as ICCLabelProtocol).Text, m_strFontName, m_uFontSize);
            Label = label;
        }
    }
}