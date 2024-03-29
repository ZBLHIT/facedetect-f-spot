//
// Cairo.cs - a simplistic binding of the Cairo API to C#.
//
// Authors: Duncan Mak (duncan@ximian.com)
//          Hisham Mardam Bey (hisham.mardambey@gmail.com)
//          John Luke (john.luke@gmail.com)
//          Alp Toker (alp@atoker.com)
//
// (C) Ximian, Inc. 2003
// Copyright (C) 2004 Novell, Inc (http://www.novell.com)
// Copyright (C) 2005 John Luke
// Copyright (C) 2006 Alp Toker
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//

using System;
using System.Runtime.InteropServices;

namespace Cairo
{
	// sort these so it is easier to find what is missing
	// http://www.cairographics.org/manual/ix01.html
	// FIXME: this should be static and named NativeMethods
	internal sealed class CairoAPI
	{
		const string cairo = "libcairo-2.dll";
		
		private CairoAPI ()
		{
		}
		
		//[DllImport (cairo)]
		//internal static extern void cairo_append_path (IntPtr cr, Path path);
		
		[DllImport (cairo)]
		internal static extern void cairo_arc (IntPtr cr, double xc, double yc, double radius, double angle1, double angle2);
		
		[DllImport (cairo)]
		internal static extern void cairo_arc_negative (IntPtr cr, double xc, double yc, double radius, double angle1, double angle2);

		[DllImport (cairo)]
		internal static extern IntPtr cairo_atsui_font_face_create_for_atsu_font_id (IntPtr font_id);
		
		[DllImport (cairo)]
		internal static extern void cairo_clip (IntPtr cr);
		
		[DllImport (cairo)]
		internal static extern void cairo_clip_preserve (IntPtr cr);

#if CAIRO_1_4
		[DllImport (cairo)]
		internal static extern void cairo_clip_extents (IntPtr cr, out double x1, out double y1, out double x2, out double y2);
#endif
		
		[DllImport (cairo)]
		internal static extern void cairo_close_path (IntPtr cr);
		
		[DllImport (cairo)]
		internal static extern void cairo_copy_page (IntPtr cr);
		
		//[DllImport (cairo)]
		//internal static extern Path cairo_copy_path (IntPtr cr);
		
		//[DllImport (cairo)]
		//internal static extern Path cairo_copy_path_flat (IntPtr cr);
		
		[DllImport (cairo)]
		internal static extern IntPtr cairo_create (IntPtr target);
		
		[DllImport (cairo)]
		internal static extern void cairo_curve_to (IntPtr cr, double x1, double y1, double x2, double y2, double x3, double y3);
		
		[DllImport (cairo)]
		internal static extern void cairo_debug_reset_static_data ();
		
		[DllImport (cairo)]
		internal static extern void cairo_destroy (IntPtr cr);
		
		[DllImport (cairo)]
		internal static extern void cairo_device_to_user (IntPtr cr, ref double x, ref double y);
		
		[DllImport (cairo)]
		internal static extern void cairo_device_to_user_distance (IntPtr cr, ref double dx, ref double dy);

		[DllImport (cairo)]
		internal static extern void cairo_fill (IntPtr cr);
		
		[DllImport (cairo)]
		internal static extern void cairo_fill_extents (IntPtr cr, out double x1, out double y1, out double x2, out double y2);
		
		[DllImport (cairo)]
		internal static extern void cairo_fill_preserve (IntPtr cr);
		
		[DllImport (cairo)]
		internal static extern void cairo_font_extents (IntPtr cr, ref FontExtents extents);
		
		// FontFace
		[DllImport (cairo)]
		internal static extern void cairo_font_face_destroy (IntPtr font_face);

#if CAIRO_1_2		
		[DllImport (cairo)]
		internal static extern FontType cairo_font_face_get_type (IntPtr font_face);
#endif

		//[DllImport (cairo)]
		//internal static extern void cairo_font_face_get_user_data (IntPtr font_face);
		
		//[DllImport (cairo)]
		//internal static extern void cairo_font_face_set_user_data (IntPtr font_face);
		
		[DllImport (cairo)]
		internal static extern IntPtr cairo_font_face_reference (IntPtr font_face);
		
		[DllImport (cairo)]
		internal static extern Status cairo_font_face_status (IntPtr font_face);
		
		// FontOptions
		[DllImport (cairo)]
		internal static extern IntPtr cairo_font_options_copy (IntPtr original);
		
		[DllImport (cairo)]
		internal static extern IntPtr cairo_font_options_create ();
		
		[DllImport (cairo)]
		internal static extern void cairo_font_options_destroy (IntPtr options);
		
		[DllImport (cairo)]
		[return: MarshalAs (UnmanagedType.U1)]
		internal static extern bool cairo_font_options_equal (IntPtr options, IntPtr other);
		
		[DllImport (cairo)]
		internal static extern Antialias cairo_font_options_get_antialias (IntPtr options);
		
		[DllImport (cairo)]
		internal static extern HintMetrics cairo_font_options_get_hint_metrics (IntPtr options);
		
		[DllImport (cairo)]
		internal static extern HintStyle cairo_font_options_get_hint_style (IntPtr options);
		
		[DllImport (cairo)]
		internal static extern SubpixelOrder cairo_font_options_get_subpixel_order (IntPtr options);
		
		[DllImport (cairo)]
		internal static extern long cairo_font_options_hash (IntPtr options);
		
		[DllImport (cairo)]
		internal static extern void cairo_font_options_merge (IntPtr options, IntPtr other);
		
		[DllImport (cairo)]
		internal static extern void cairo_font_options_set_antialias (IntPtr options, Antialias aa);
		
		[DllImport (cairo)]
		internal static extern void cairo_font_options_set_hint_metrics (IntPtr options, HintMetrics metrics);
		
		[DllImport (cairo)]
		internal static extern void cairo_font_options_set_hint_style (IntPtr options, HintStyle style);
		
		[DllImport (cairo)]
		internal static extern void cairo_font_options_set_subpixel_order (IntPtr options, SubpixelOrder order);
		
		[DllImport (cairo)]
		internal static extern Status cairo_font_options_status (IntPtr options);
		
		// Freetype / FontConfig 
		[DllImport (cairo)]
		internal static extern IntPtr cairo_ft_font_face_create_for_ft_face (IntPtr face, int load_flags);
		
		[DllImport (cairo)]
		internal static extern IntPtr cairo_ft_font_face_create_for_pattern (IntPtr fc_pattern);
		
		[DllImport (cairo)]
		internal static extern void cairo_ft_font_options_substitute (FontOptions options, IntPtr pattern);
		
		[DllImport (cairo)]
		internal static extern IntPtr cairo_ft_scaled_font_lock_face (IntPtr scaled_font);
		
		[DllImport (cairo)]
		internal static extern void cairo_ft_scaled_font_unlock_face (IntPtr scaled_font);
		
		[DllImport (cairo)]
		internal static extern Antialias cairo_get_antialias (IntPtr cr);
		
		[DllImport (cairo)]
		internal static extern void cairo_get_current_point (IntPtr cr, out double x, out double y);
		
		[DllImport (cairo)]
		internal static extern FillRule cairo_get_fill_rule (IntPtr cr);
		
		[DllImport (cairo)]
		internal static extern IntPtr cairo_get_font_face (IntPtr cr);
		
		[DllImport (cairo)]
		internal static extern Matrix cairo_get_font_matrix (IntPtr cr);
		
		[DllImport (cairo)]
		internal static extern void cairo_get_font_options (IntPtr cr, IntPtr options);

		[DllImport (cairo)]
		internal static extern IntPtr cairo_get_group_target (IntPtr cr);
		
		[DllImport (cairo)]
		internal static extern LineCap cairo_get_line_cap (IntPtr cr);
		
		[DllImport (cairo)]
		internal static extern LineJoin cairo_get_line_join (IntPtr cr);
		
		[DllImport (cairo)]
		internal static extern double cairo_get_line_width (IntPtr cr);
		
		[DllImport (cairo)]
		internal static extern void cairo_get_matrix (IntPtr cr, Matrix matrix);
		
		[DllImport (cairo)]
		internal static extern double cairo_get_miter_limit (IntPtr cr);
		
		[DllImport (cairo)]
		internal static extern Operator cairo_get_operator (IntPtr cr);
		
		[DllImport (cairo)]
		internal static extern IntPtr cairo_get_source (IntPtr cr);
		
		[DllImport (cairo)]
		internal static extern IntPtr cairo_get_target (IntPtr cr);
		
		[DllImport (cairo)]
		internal static extern double cairo_get_tolerance (IntPtr cr);
		
		[DllImport (cairo)]
		internal static extern IntPtr cairo_glitz_surface_create (IntPtr surface);

		[DllImport (cairo)]
		internal static extern void cairo_glyph_extents (IntPtr cr, IntPtr glyphs, int num_glyphs, TextExtents extents);
		
		[DllImport (cairo)]
		internal static extern void cairo_glyph_path (IntPtr cr, IntPtr glyphs, int num_glyphs);
		
		[DllImport (cairo)]
		internal static extern void cairo_identity_matrix (IntPtr cr);
		
		// ImageSurface
		[DllImport (cairo)]
		internal static extern IntPtr cairo_image_surface_create (Cairo.Format format, int width, int height);
		
		[DllImport (cairo)]
		internal static extern IntPtr cairo_image_surface_create_for_data (byte[] data, Cairo.Format format, int width, int height, int stride);
		
		[DllImport (cairo)]
		internal static extern IntPtr cairo_image_surface_create_for_data (IntPtr data, Cairo.Format format, int width, int height, int stride);
		
		[DllImport (cairo)]
		internal static extern IntPtr cairo_image_surface_create_from_png  (string filename);
		
		//[DllImport (cairo)]
		//internal static extern IntPtr cairo_image_surface_create_from_png_stream  (string filename);

		[DllImport (cairo)]
		internal static extern IntPtr cairo_image_surface_get_data (IntPtr surface);

		[DllImport (cairo)]
		internal static extern Format cairo_image_surface_get_format (IntPtr surface);
		
		[DllImport (cairo)]
		internal static extern int cairo_image_surface_get_height (IntPtr surface);

		[DllImport (cairo)]
		internal static extern int cairo_image_surface_get_stride (IntPtr surface);
		
		[DllImport (cairo)]
		internal static extern int cairo_image_surface_get_width  (IntPtr surface);
		
		[DllImport (cairo)]
		[return: MarshalAs (UnmanagedType.U1)]
		internal static extern bool cairo_in_fill (IntPtr cr, double x, double y);
		
		[DllImport (cairo)]
		[return: MarshalAs (UnmanagedType.U1)]
		internal static extern bool cairo_in_stroke (IntPtr cr, double x, double y);
		
		[DllImport (cairo)]
		internal static extern void cairo_line_to (IntPtr cr, double x, double y);
		
		[DllImport (cairo)]
		internal static extern void cairo_mask (IntPtr cr, IntPtr pattern);
		
		[DllImport (cairo)]
		internal static extern void cairo_mask_surface (IntPtr cr, IntPtr surface, double x, double y);
		
		// Matrix
		[DllImport (cairo)]
		internal static extern void cairo_matrix_init (Matrix matrix, double xx, double yx, double xy, double yy, double x0, double y0);
		
		[DllImport (cairo)]
		internal static extern void cairo_matrix_init_identity (Matrix matrix);
		
		[DllImport (cairo)]
		internal static extern void cairo_matrix_init_rotate (Matrix matrix, double radians);
		
		[DllImport (cairo)]
		internal static extern void cairo_matrix_init_scale (Matrix matrix, double sx, double sy);
		
		[DllImport (cairo)]
		internal static extern void cairo_matrix_init_translate (Matrix matrix, double tx, double ty);
		
		[DllImport (cairo)]
		internal static extern Status cairo_matrix_invert (Matrix matrix);
		
		[DllImport (cairo)]
		internal static extern void cairo_matrix_multiply (Matrix result, Matrix a, Matrix b);
		
		[DllImport (cairo)]
		internal static extern void cairo_matrix_scale (Matrix matrix, double sx, double sy);
		
		[DllImport (cairo)]
		internal static extern void cairo_matrix_rotate (Matrix matrix, double radians);
		
		[DllImport (cairo)]
		internal static extern void cairo_matrix_transform_distance (Matrix matrix, ref double dx, ref double dy);
		
		[DllImport (cairo)]
		internal static extern void cairo_matrix_transform_point (Matrix matrix, ref double x, ref double y);
		
		[DllImport (cairo)]
		internal static extern void cairo_matrix_translate (Matrix matrix, double tx, double ty);
		
		[DllImport (cairo)]
		internal static extern void cairo_move_to (IntPtr cr, double x, double y);
		
		[DllImport (cairo)]
		internal static extern void cairo_new_path (IntPtr cr);

		[DllImport (cairo)]
		internal static extern void cairo_new_sub_path (IntPtr cr);
		
		[DllImport (cairo)]
		internal static extern void cairo_paint (IntPtr cr);
		
		[DllImport (cairo)]
		internal static extern void cairo_paint_with_alpha (IntPtr cr, double alpha);
		
		[DllImport (cairo)]
		internal static extern void cairo_path_destroy (IntPtr path);
		
		// Pattern
		[DllImport (cairo)]
		internal static extern void cairo_pattern_add_color_stop_rgb (IntPtr pattern, double offset, double red, double green, double blue);
		
		[DllImport (cairo)]
		internal static extern void cairo_pattern_add_color_stop_rgba (IntPtr pattern, double offset, double red, double green, double blue, double alpha);

#if CAIRO_1_4
		[DllImport (cairo)]
		internal static extern Status cairo_pattern_get_color_stop_count (IntPtr pattern, out int count);
		[DllImport (cairo)]
		internal static extern Status cairo_pattern_get_color_stop_rgba (IntPtr pattern, int index, out double offset, out double red, out double green, out double blue, out double alpha);
#endif
		
		[DllImport (cairo)]
		internal static extern IntPtr cairo_pattern_create_for_surface (IntPtr surface);

#if CAIRO_1_4
		[DllImport (cairo)]
		internal static extern Status cairo_pattern_get_surface (IntPtr pattern, out IntPtr surface);
#endif
		
		[DllImport (cairo)]
		internal static extern IntPtr cairo_pattern_create_linear (double x0, double y0, double x1, double y1);

#if CAIRO_1_4
		[DllImport (cairo)]
		internal static extern Status cairo_pattern_get_linear_points (IntPtr pattern, out double x0, out double y0, out double x1, out double y1);
#endif
		
		[DllImport (cairo)]
		internal static extern IntPtr cairo_pattern_create_radial (double cx0, double cy0, double radius0, double cx1, double cy1, double radius1);

#if CAIRO_1_4
		[DllImport (cairo)]
		internal static extern Status cairo_pattern_get_radial_circles (IntPtr pattern, out double x0, out double y0, out double r0, out double x1, out double y1, out double r1);
#endif
		
		[DllImport (cairo)]
		internal static extern IntPtr cairo_pattern_create_rgb (double r, double g, double b);
		
		[DllImport (cairo)]
		internal static extern IntPtr cairo_pattern_create_rgba (double r, double g, double b, double a);

#if CAIRO_1_4
		[DllImport (cairo)]
		internal static extern Status cairo_pattern_get_rgba (IntPtr pattern, out double red, out double green, out double blue, out double alpha);
#endif
		
		[DllImport (cairo)]
		internal static extern void cairo_pattern_destroy (IntPtr pattern);
		
		[DllImport (cairo)]
		internal static extern Extend cairo_pattern_get_extend (IntPtr pattern);
		
		[DllImport (cairo)]
		internal static extern Filter cairo_pattern_get_filter (IntPtr pattern);
		
		[DllImport (cairo)]
		internal static extern void cairo_pattern_get_matrix (IntPtr pattern, Matrix matrix);

#if CAIRO_1_2
		[DllImport (cairo)]
		internal static extern PatternType cairo_pattern_get_type (IntPtr pattern);
#endif
		
		[DllImport (cairo)]
		internal static extern IntPtr cairo_pattern_reference (IntPtr pattern);
		
		[DllImport (cairo)]
		internal static extern void cairo_pattern_set_extend (IntPtr pattern, Extend extend);
		
		[DllImport (cairo)]
		internal static extern void cairo_pattern_set_filter (IntPtr pattern, Filter filter);
		
		[DllImport (cairo)]
		internal static extern void cairo_pattern_set_matrix (IntPtr pattern, Matrix matrix);
		
		[DllImport (cairo)]
		internal static extern Status cairo_pattern_status (IntPtr pattern);
	
		// PdfSurface
		[DllImport (cairo)]
		internal static extern IntPtr cairo_pdf_surface_create (string filename, double width, double height);
		
		//[DllImport (cairo)]
		//internal static extern IntPtr cairo_pdf_surface_create_for_stream (string filename, double width, double height);
		
		[DllImport (cairo)]
		internal static extern void cairo_pdf_surface_set_size (IntPtr surface, double x, double y);
		
		// PostscriptSurface
		[DllImport (cairo)]
		internal static extern IntPtr cairo_ps_surface_create (string filename, double width, double height);
		
		//[DllImport (cairo)]
		//internal static extern IntPtr cairo_ps_surface_create_for_stream (string filename, double width, double height);
		[DllImport (cairo)]
		internal static extern void cairo_ps_surface_begin_page_setup (IntPtr surface);
		
		[DllImport (cairo)]
		internal static extern void cairo_ps_surface_begin_setup (IntPtr surface);
		
		[DllImport (cairo)]
		internal static extern void cairo_ps_surface_dsc_comment (IntPtr surface, string comment);
		
		[DllImport (cairo)]
		internal static extern void cairo_ps_surface_set_size (IntPtr surface, double x, double y);

		[DllImport (cairo)]
		internal static extern IntPtr cairo_pop_group (IntPtr cr);

		[DllImport (cairo)]
		internal static extern void cairo_pop_group_to_source (IntPtr cr);

		[DllImport (cairo)]
		internal static extern void cairo_push_group (IntPtr cr);

		[DllImport (cairo)]
		internal static extern void cairo_push_group_with_content (IntPtr cr, Content content);

		[DllImport (cairo)]
		internal static extern IntPtr cairo_quartz_surface_create (IntPtr context, bool flipped, int width, int height);

		[DllImport (cairo)]
		internal static extern void cairo_rectangle (IntPtr cr, double x, double y, double width, double height);
		
		[DllImport (cairo)]
		internal static extern void cairo_reference (IntPtr cr);
		
		[DllImport (cairo)]
		internal static extern void cairo_rel_curve_to (IntPtr cr, double dx1, double dy1, double dx2, double dy2, double dx3, double dy3);
		
		[DllImport (cairo)]
		internal static extern void cairo_rel_line_to (IntPtr cr, double dx, double dy);
		
		[DllImport (cairo)]
		internal static extern void cairo_rel_move_to (IntPtr cr, double dx, double dy);
		
		[DllImport (cairo)]
		internal static extern void cairo_reset_clip (IntPtr cr);
		
		[DllImport (cairo)]
		internal static extern void cairo_restore (IntPtr cr);
		
		[DllImport (cairo)]
		internal static extern void cairo_rotate (IntPtr cr, double angle);
		
		[DllImport (cairo)]
		internal static extern void cairo_save (IntPtr cr);
		
		[DllImport (cairo)]
		internal static extern void cairo_scale (IntPtr cr, double sx, double sy);
		
		// ScaledFont
		[DllImport (cairo)]
		internal static extern IntPtr cairo_scaled_font_create (IntPtr fontFace, Matrix matrix, Matrix ctm, IntPtr options);
		
		[DllImport (cairo)]
		internal static extern IntPtr cairo_scaled_font_destroy (IntPtr scaled_font);
		
		[DllImport (cairo)]
		internal static extern void cairo_scaled_font_extents (IntPtr scaled_font, TextExtents extents);

#if CAIRO_1_2		
		[DllImport (cairo)]
		internal static extern void cairo_scaled_font_get_ctm (IntPtr scaled_font, out Matrix matrix);

		[DllImport (cairo)]
		internal static extern IntPtr cairo_scaled_font_get_font_face (IntPtr scaled_font);

		[DllImport (cairo)]
		internal static extern void cairo_scaled_font_get_font_matrix (IntPtr scaled_font, out Matrix matrix);

		[DllImport (cairo)]
		internal static extern IntPtr cairo_scaled_font_get_font_options (IntPtr scaled_font);

		[DllImport (cairo)]
		internal static extern FontType cairo_scaled_font_get_type (IntPtr scaled_font);
#endif

		[DllImport (cairo)]
		internal static extern void cairo_scaled_font_glyph_extents (IntPtr scaled_font, IntPtr glyphs, int num_glyphs, TextExtents extents);
		
		[DllImport (cairo)]
		internal static extern IntPtr cairo_scaled_font_reference (IntPtr scaled_font);

		[DllImport (cairo)]
		internal static extern Status cairo_scaled_font_status (IntPtr scaled_font);

#if CAIRO_1_2		
		[DllImport (cairo)]
		internal static extern void cairo_scaled_font_text_extents (IntPtr scaled_font, string utf8, ref TextExtents extents);
#endif
		
		[DllImport (cairo)]
		internal static extern void cairo_select_font_face (IntPtr cr, string family, FontSlant slant, FontWeight weight);
		
		[DllImport (cairo)]
		internal static extern void cairo_set_antialias (IntPtr cr, Antialias antialias);
		
		[DllImport (cairo)]
		internal static extern void cairo_set_dash (IntPtr cr, double [] dashes, int ndash, double offset);

#if CAIRO_1_4
		[DllImport (cairo)]
		internal static extern Status cairo_get_dash (IntPtr cr, IntPtr dashes, out double offset);

		[DllImport (cairo)]
		internal static extern Status cairo_get_dash_count (IntPtr cr, out int count);
#endif
		
		[DllImport (cairo)]
		internal static extern void cairo_set_fill_rule (IntPtr cr, Cairo.FillRule fill_rule);
		
		[DllImport (cairo)]
		internal static extern void cairo_set_font_face (IntPtr cr, IntPtr fontFace);
		
		[DllImport (cairo)]
		internal static extern void cairo_set_font_matrix (IntPtr cr, Matrix matrix);
		
		[DllImport (cairo)]
		internal static extern void cairo_set_font_options (IntPtr cr, IntPtr options);
		
		[DllImport (cairo)]
		internal static extern void cairo_set_font_size (IntPtr cr, double size);
		
		[DllImport (cairo)]
		internal static extern void cairo_set_line_cap (IntPtr cr, LineCap line_cap);
		
		[DllImport (cairo)]
		internal static extern void cairo_set_line_join (IntPtr cr, LineJoin line_join);
		
		[DllImport (cairo)]
		internal static extern void cairo_set_line_width (IntPtr cr, double width);
		
		[DllImport (cairo)]
		internal static extern void cairo_set_matrix (IntPtr cr, Matrix matrix);
		
		[DllImport (cairo)]
		internal static extern void cairo_set_miter_limit (IntPtr cr, double limit);
		
		[DllImport (cairo)]
		internal static extern void cairo_set_operator (IntPtr cr, Cairo.Operator op);
		
		[DllImport (cairo)]
		internal static extern void cairo_set_source (IntPtr cr, IntPtr pattern);
		
		[DllImport (cairo)]
		internal static extern void cairo_set_source_rgb (IntPtr cr, double red, double green, double blue);

		[DllImport (cairo)]
		internal static extern void cairo_set_source_rgba (IntPtr cr, double red, double green, double blue, double alpha);
		
		[DllImport (cairo)]
		internal static extern void cairo_set_source_surface (IntPtr cr, IntPtr surface, double x, double y);
		
		[DllImport (cairo)]
		internal static extern void cairo_set_tolerance (IntPtr cr, double tolerance);
		
		[DllImport (cairo)]
		internal static extern void cairo_show_glyphs (IntPtr ct, IntPtr glyphs, int num_glyphs);
		
		[DllImport (cairo)]
		internal static extern void cairo_show_page (IntPtr cr);
		
		[DllImport (cairo)]
		internal static extern void cairo_show_text (IntPtr cr, string utf8);
		
		[DllImport (cairo)]
		internal static extern Status cairo_status (IntPtr cr);
		
		[DllImport (cairo)]
		internal static extern IntPtr cairo_status_to_string (Status status);
		
		[DllImport (cairo)]
		internal static extern void cairo_stroke (IntPtr cr);
		
		[DllImport (cairo)]
		internal static extern void cairo_stroke_extents (IntPtr cr, out double x1, out double y1, out double x2, out double y2);
		
		[DllImport (cairo)]
		internal static extern void cairo_stroke_preserve (IntPtr cr);
		
#if CAIRO_1_4
		[DllImport (cairo)]
		internal static extern void cairo_rectangle_list_destroy (IntPtr rectangle_list);

		[DllImport (cairo)]
		internal static extern IntPtr cairo_copy_clip_rectangles (IntPtr cr);
#endif

		// Surface
		[DllImport (cairo)]
		internal static extern IntPtr cairo_surface_create_similar (IntPtr surface, Cairo.Content content, int width, int height);
		
		[DllImport (cairo)]
		internal static extern void cairo_surface_destroy (IntPtr surface);
		
		[DllImport (cairo)]
		internal static extern void cairo_surface_finish (IntPtr surface);
		
		[DllImport (cairo)]
		internal static extern void cairo_surface_flush (IntPtr surface);

		[DllImport (cairo)]
		internal static extern Content cairo_surface_get_content (IntPtr surface);
		
		[DllImport (cairo)]
		internal static extern void cairo_surface_get_device_offset (IntPtr surface, out double x, out double y);

		[DllImport (cairo)]
		internal static extern void cairo_surface_get_font_options (IntPtr surface, IntPtr FontOptions);

#if CAIRO_1_2
		[DllImport (cairo)]
		internal static extern SurfaceType cairo_surface_get_type (IntPtr surface);
#endif
		
		[DllImport (cairo)]
		internal static extern void cairo_surface_mark_dirty (IntPtr surface);
		
		[DllImport (cairo)]
		internal static extern void cairo_surface_mark_dirty_rectangle (IntPtr surface, int x, int y, int width, int height);
		
		[DllImport (cairo)]
		internal static extern IntPtr cairo_surface_reference (IntPtr surface);
		
		[DllImport (cairo)]
		internal static extern void cairo_surface_set_device_offset (IntPtr surface, double x, double y);

		[DllImport (cairo)]
		internal static extern void cairo_surface_set_fallback_resolution (IntPtr surface, double x, double y);
		
		[DllImport (cairo)]
		internal static extern Status cairo_surface_status (IntPtr surface);
		
		[DllImport (cairo)]
		internal static extern void cairo_surface_write_to_png (IntPtr surface, string filename);
		
		//[DllImport (cairo)]
		//internal static extern void cairo_surface_write_to_png_stream (IntPtr surface, WriteFunc writeFunc);
		
		[DllImport (cairo)]
		internal static extern IntPtr cairo_svg_surface_create (string fileName, double width, double height);
		
		//[DllImport (cairo)]
		//internal static extern IntPtr cairo_svg_surface_create_for_stream (double width, double height);
		
#if CAIRO_1_2
		[DllImport (cairo)]
		internal static extern IntPtr cairo_svg_surface_restrict_to_version (IntPtr surface, SvgVersion version);
#endif
		
		[DllImport (cairo)]
		internal static extern void cairo_text_extents (IntPtr cr, string utf8, ref TextExtents extents);
		
		[DllImport (cairo)]
		internal static extern void cairo_text_path (IntPtr ct, string utf8);
		
		[DllImport (cairo)]
		internal static extern void cairo_transform (IntPtr cr, Matrix matrix);
		
		[DllImport (cairo)]
		internal static extern void cairo_translate (IntPtr cr, double tx, double ty);
		
		[DllImport (cairo)]
		internal static extern void cairo_user_to_device (IntPtr cr, ref double x, ref double y);
		
		[DllImport (cairo)]
		internal static extern void cairo_user_to_device_distance (IntPtr cr, ref double dx, ref double dy);
		
		[DllImport (cairo)]
		internal static extern int cairo_version ();
		
		[DllImport (cairo)]
		internal static extern IntPtr cairo_version_string ();
		
		// DirectFBSurface
		[DllImport (cairo)]
		internal static extern IntPtr cairo_directfb_surface_create (IntPtr dfb, IntPtr surface);
		
		// win32 fonts
		[DllImport (cairo)]
		internal static extern IntPtr cairo_win32_font_face_create_for_logfontw (IntPtr logfontw);
		
		[DllImport (cairo)]
		internal static extern void cairo_win32_scaled_font_done_font (IntPtr scaled_font);
		
		[DllImport (cairo)]
		internal static extern double cairo_win32_scaled_font_get_metrics_factor (IntPtr scaled_font);
		
		[DllImport (cairo)]
		internal static extern Status cairo_win32_scaled_font_select_font (IntPtr scaled_font, IntPtr hdc);
		
		// win32 surface
		[DllImport (cairo)]
		internal static extern IntPtr cairo_win32_surface_create (IntPtr hdc);
		
#if CAIRO_1_4
		[DllImport (cairo)]
		internal static extern IntPtr cairo_win32_surface_create_with_ddb (IntPtr hdc, Format format, int width, int height);
#endif

		// XcbSurface
		[DllImport (cairo)]
		internal static extern IntPtr cairo_xcb_surface_create (IntPtr connection, uint drawable, IntPtr visual, int width, int height);
		
		[DllImport (cairo)]
		internal static extern IntPtr cairo_xcb_surface_create_for_bitmap (IntPtr connection, uint bitmap, IntPtr screen, int width, int height);
		
		[DllImport (cairo)]
		internal static extern void cairo_xcb_surface_set_size (IntPtr surface, int width, int height);
		
		// XlibSurface
		[DllImport (cairo)]
		internal static extern IntPtr cairo_xlib_surface_create (IntPtr display, IntPtr drawable, IntPtr visual, int width, int height);
		
		[DllImport (cairo)]
		internal static extern IntPtr cairo_xlib_surface_create_for_bitmap (IntPtr display, IntPtr bitmap, IntPtr screen, int width, int height);
		
		[DllImport (cairo)]
		internal static extern int cairo_xlib_surface_get_depth (IntPtr surface);

		[DllImport (cairo)]
		internal static extern IntPtr cairo_xlib_surface_get_display (IntPtr surface);

		[DllImport (cairo)]
		internal static extern IntPtr cairo_xlib_surface_get_drawable (IntPtr surface);

		[DllImport (cairo)]
		internal static extern int cairo_xlib_surface_get_height (IntPtr surface);

		[DllImport (cairo)]
		internal static extern IntPtr cairo_xlib_surface_get_screen (IntPtr surface);

		[DllImport (cairo)]
		internal static extern IntPtr cairo_xlib_surface_get_visual (IntPtr surface);

		[DllImport (cairo)]
		internal static extern int cairo_xlib_surface_get_width (IntPtr surface);
		
		[DllImport (cairo)]
		internal static extern void cairo_xlib_surface_set_drawable (IntPtr surface, IntPtr drawable, int width, int height);
		
		[DllImport (cairo)]
		internal static extern void cairo_xlib_surface_set_size (IntPtr surface, int width, int height);
	}
}
