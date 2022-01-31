using SomeChartsUi.themes.colors;
using SomeChartsUi.ui.canvas;
using SomeChartsUi.ui.elements;
using SomeChartsUi.ui.text;
using SomeChartsUi.utils.rects;
using SomeChartsUi.utils.vectors;

namespace SomeChartsUi.backends; 

/// <summary>
/// all positions and scales are in screen-space transform
/// </summary>
public abstract class ChartsBackendBase {
	public ChartsCanvas owner = null!;
	public ChartCanvasRenderer renderer = null!;

	public abstract unsafe void DrawMesh(float2* points, float2* uvs, color* colors, ushort* indexes, int vertexCount, int indexCount, RenderableTransform transform);
	public abstract void DrawMesh(float2[] points, float2[]? uvs, color[]? colors, ushort[] indexes, RenderableTransform transform);
	
	public abstract void DrawText(string text, color col, FontData font, RenderableTransform transform);

	public abstract void DrawRect(rect rectangle, color color);
	
	
}