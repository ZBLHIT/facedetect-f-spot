using System;
using Gtk;
using Gdk;

namespace FSpot {
public class TagView : EventBox {
	private int thumbnail_size = 20;
	private IBrowsableItem photo;
	private Tag [] tags;
	private static int TAG_ICON_VSPACING = 5;
	bool parent_tip;

	public TagView ()
	{
		VisibleWindow = false;
	}

	public IBrowsableItem Current {
		set {
			photo = value;

			if (photo != null && photo.Tags != null) {
				SetSizeRequest ((thumbnail_size + TAG_ICON_VSPACING) * photo.Tags.Length,
						thumbnail_size);
			} else {
				SetSizeRequest (0, thumbnail_size);	
			}
			QueueResize ();
			QueueDraw ();
		}
	}

	public Tag [] Tags {
		get {
			return tags;
		}
		set {
			this.tags = value;
			this.QueueDraw ();
		}
	}
	
	protected override bool OnExposeEvent (Gdk.EventExpose args)
	{
		if (photo != null)
			tags = photo.Tags;

		if (tags == null)
			return base.OnExposeEvent (args);

		SetSizeRequest ((thumbnail_size + TAG_ICON_VSPACING) * tags.Length,
				thumbnail_size);

		int tag_x = Allocation.X;
		int tag_y = Allocation.Y + (Allocation.Height - thumbnail_size)/2;
		
		string [] names = new string [tags.Length];
		int i = 0;
		foreach (Tag t in tags) {
			names [i++] = t.Name;
			
			Pixbuf icon = t.Icon;

			Category category = t.Category;
			while (icon == null && category != null) {
				icon = category.Icon;
				category = category.Category;
			}
			
			if (icon == null)
				continue;
			
			Pixbuf scaled_icon;
			if (icon.Width == thumbnail_size) {
				scaled_icon = icon;
			} else {
				scaled_icon = icon.ScaleSimple (thumbnail_size, thumbnail_size, InterpType.Bilinear);
			}

			scaled_icon.RenderToDrawable (GdkWindow, Style.WhiteGC,
						      0, 0, tag_x, tag_y, thumbnail_size, thumbnail_size,
						      RgbDither.None, tag_x, tag_y);
			tag_x += thumbnail_size + TAG_ICON_VSPACING;
		}
		MainWindow.SetTip (this, String.Join (", ", names));

		return base.OnExposeEvent (args);
	}
}
}
