using com.igetui.api.openservice;

namespace smgrushb.GeTui.Domain.PushStrategy
{
    internal abstract class BasePush : IGtPush
    {
        protected BasePush(GeTui geTui) : base(Keys.Host, Keys.AppKey, Keys.MasterSecret)
        {
            GeTui = geTui;
        }

        public virtual GeTui GeTui { get; }

        public abstract string Push();
    }
}