
namespace cocos2d
{
    /// <summary>
    /// brief CCScene is a subclass of CCNode that is used only as an abstract concept.
    /// CCScene an CCNode are almost identical with the difference that CCScene has it's
    /// anchor point (by default) at the center of the screen.
    /// For the moment CCScene has no other logic than that, but in future releases it might have
    /// additional logic.
    ///  It is a good practice to use and CCScene as the parent of all your nodes.
    /// </summary>
    public class CCScene : CCNode
    {
        public CCScene()
        {
            m_bIgnoreAnchorPointForPosition = true;
            AnchorPoint = new CCPoint(0.5f, 0.5f);
        }

        public bool Init()
        {
            bool bRet = false;
            do
            {
                CCDirector director = CCDirector.SharedDirector;
                if (director == null)
                {
                    break;
                }

                ContentSize = director.WinSize;
                // success
                bRet = true;
            } while (false);
            return bRet;
        }

        public new static CCScene Create()
        {
            var pRet = new CCScene();
            pRet.Init();
            return pRet;
        }
    }
}