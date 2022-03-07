using FreeTypeSharp;
using MathStuff;
using MathStuff.vectors;
using SomeChartsUi.ui.canvas;
using SomeChartsUi.ui.elements;
using SomeChartsUi.ui.layers;
using SomeChartsUi.ui.text;
using SomeChartsUi.utils.mesh;
using SomeChartsUi.utils.shaders;

namespace SomeChartsUi.backends; 

/// <summary>
/// all positions and scales are in screen-space transform
/// </summary>
public abstract class ChartsBackendBase {
	public ChartsCanvas owner = null!;
	public ChartCanvasRenderer renderer = null!;

	public abstract void DrawText(string text, color col, FontData font, RenderableTransform transform);
	
	public abstract void ClearScreen(color col);
	
	public abstract void DrawMesh(Mesh mesh, Material? material, RenderableTransform transform);
}