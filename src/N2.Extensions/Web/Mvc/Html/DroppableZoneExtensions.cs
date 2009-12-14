using System;
using N2.Web.UI;
using N2.Web.UI.WebControls;
using System.Web;
using System.Web.Mvc;

namespace N2.Web.Mvc.Html
{
	public static class DroppableZoneExtensions
	{
        public static ControlPanelState ControlPanelState(this HttpContextBase context)
        {
            return ControlPanel.GetState(context.User, context.Request.QueryString);
        }

        /// <summary>
        /// Gets the HTML for all items in the Zone of the given name from the item held by the <see cref="container" />.
        /// </summary>
        /// <remarks>This extension method at the moment does not implement the drag & drop functionality.</remarks>
        /// <param name="container"></param>
        /// <param name="zoneName"></param>
        /// <returns></returns>
        public static DroppableZoneHelper DroppableZone(this HtmlHelper helper, string zoneName)
        {
            return new DroppableZoneHelper(helper.ViewContext, zoneName, helper.CurrentItem());
        }

        /// <summary>
        /// Gets the HTML for all items in the Zone of the given name from the <see cref="item" /> given.
        /// </summary>
        /// <remarks>This extension method at the moment does not implement the drag & drop functionality.</remarks>
        /// <param name="container"></param>
        /// <param name="zoneName"></param>
        /// <returns></returns>
        public static DroppableZoneHelper DroppableZone(this HtmlHelper helper, ContentItem item, string zoneName)
        {
            return new DroppableZoneHelper(helper.ViewContext, zoneName, item);
        }
	}
}