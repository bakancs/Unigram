﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//       LottieGen version:
//           7.1.0+ge1fa92580f
//       
//       Command:
//           LottieGen -Language CSharp -Namespace Unigram.Assets.Icons -Public -WinUIVersion 2.7 -InputFile Username.json
//       
//       Input file:
//           Username.json (4132 bytes created 17:41+01:00 Dec 21 2021)
//       
//       LottieGen source:
//           http://aka.ms/Lottie
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
// ____________________________________
// |       Object stats       | Count |
// |__________________________|_______|
// | All CompositionObjects   |    52 |
// |--------------------------+-------|
// | Expression animators     |     5 |
// | KeyFrame animators       |     5 |
// | Reference parameters     |     5 |
// | Expression operations    |     0 |
// |--------------------------+-------|
// | Animated brushes         |     1 |
// | Animated gradient stops  |     - |
// | ExpressionAnimations     |     1 |
// | PathKeyFrameAnimations   |     - |
// |--------------------------+-------|
// | ContainerVisuals         |     1 |
// | ShapeVisuals             |     1 |
// |--------------------------+-------|
// | ContainerShapes          |     - |
// | CompositionSpriteShapes  |     3 |
// |--------------------------+-------|
// | Brushes                  |     3 |
// | Gradient stops           |     - |
// | CompositionVisualSurface |     - |
// ------------------------------------
using Microsoft.Graphics.Canvas.Geometry;
using System;
using System.Collections.Generic;
using System.Numerics;
using Windows.Graphics;
using Windows.UI;
using Windows.UI.Composition;

namespace Unigram.Assets.Icons
{
    // Name:        u_username
    // Frame rate:  60 fps
    // Frame count: 30
    // Duration:    500.0 mS
    sealed class Username
        : Microsoft.UI.Xaml.Controls.IAnimatedVisualSource
        , Microsoft.UI.Xaml.Controls.IAnimatedVisualSource2
    {
        // Animation duration: 0.500 seconds.
        internal const long c_durationTicks = 5000000;

        public Microsoft.UI.Xaml.Controls.IAnimatedVisual TryCreateAnimatedVisual(Compositor compositor)
        {
            object ignored = null;
            return TryCreateAnimatedVisual(compositor, out ignored);
        }

        public Microsoft.UI.Xaml.Controls.IAnimatedVisual TryCreateAnimatedVisual(Compositor compositor, out object diagnostics)
        {
            diagnostics = null;

            if (Username_AnimatedVisual.IsRuntimeCompatible())
            {
                return
                    new Username_AnimatedVisual(
                        compositor
                        );
            }

            return null;
        }

        /// <summary>
        /// Gets the number of frames in the animation.
        /// </summary>
        public double FrameCount => 30d;

        /// <summary>
        /// Gets the frame rate of the animation.
        /// </summary>
        public double Framerate => 60d;

        /// <summary>
        /// Gets the duration of the animation.
        /// </summary>
        public TimeSpan Duration => TimeSpan.FromTicks(c_durationTicks);

        /// <summary>
        /// Converts a zero-based frame number to the corresponding progress value denoting the
        /// start of the frame.
        /// </summary>
        public double FrameToProgress(double frameNumber)
        {
            return frameNumber / 30d;
        }

        /// <summary>
        /// Returns a map from marker names to corresponding progress values.
        /// </summary>
        public IReadOnlyDictionary<string, double> Markers =>
            new Dictionary<string, double>
            {
                { "NormalToPointerOver_Start", 0.0 },
                { "NormalToPointerOver_End", 1 },
                { "PointerOverToNormal_Start", 0 },
                { "PointerOverToNormal_End", 0 },
            };

        /// <summary>
        /// Sets the color property with the given name, or does nothing if no such property
        /// exists.
        /// </summary>
        public void SetColorProperty(string propertyName, Color value)
        {
        }

        /// <summary>
        /// Sets the scalar property with the given name, or does nothing if no such property
        /// exists.
        /// </summary>
        public void SetScalarProperty(string propertyName, double value)
        {
        }

        sealed class Username_AnimatedVisual : Microsoft.UI.Xaml.Controls.IAnimatedVisual
        {
            const long c_durationTicks = 5000000;
            readonly Compositor _c;
            readonly ExpressionAnimation _reusableExpressionAnimation;
            CompositionPath _path;
            ContainerVisual _root;
            CubicBezierEasingFunction _cubicBezierEasingFunction_0;
            ExpressionAnimation _rootProgress;
            StepEasingFunction _holdThenStepEasingFunction;
            StepEasingFunction _stepThenHoldEasingFunction;

            static void StartProgressBoundAnimation(
                CompositionObject target,
                string animatedPropertyName,
                CompositionAnimation animation,
                ExpressionAnimation controllerProgressExpression)
            {
                target.StartAnimation(animatedPropertyName, animation);
                var controller = target.TryGetAnimationController(animatedPropertyName);
                controller.Pause();
                controller.StartAnimation("Progress", controllerProgressExpression);
            }

            ColorKeyFrameAnimation CreateColorKeyFrameAnimation(float initialProgress, Color initialValue, CompositionEasingFunction initialEasingFunction)
            {
                var result = _c.CreateColorKeyFrameAnimation();
                result.Duration = TimeSpan.FromTicks(c_durationTicks);
                result.InterpolationColorSpace = CompositionColorSpace.Rgb;
                result.InsertKeyFrame(initialProgress, initialValue, initialEasingFunction);
                return result;
            }

            ScalarKeyFrameAnimation CreateScalarKeyFrameAnimation(float initialProgress, float initialValue, CompositionEasingFunction initialEasingFunction)
            {
                var result = _c.CreateScalarKeyFrameAnimation();
                result.Duration = TimeSpan.FromTicks(c_durationTicks);
                result.InsertKeyFrame(initialProgress, initialValue, initialEasingFunction);
                return result;
            }

            Vector2KeyFrameAnimation CreateVector2KeyFrameAnimation(float initialProgress, Vector2 initialValue, CompositionEasingFunction initialEasingFunction)
            {
                var result = _c.CreateVector2KeyFrameAnimation();
                result.Duration = TimeSpan.FromTicks(c_durationTicks);
                result.InsertKeyFrame(initialProgress, initialValue, initialEasingFunction);
                return result;
            }

            CompositionSpriteShape CreateSpriteShape(CompositionGeometry geometry, Matrix3x2 transformMatrix)
            {
                var result = _c.CreateSpriteShape(geometry);
                result.TransformMatrix = transformMatrix;
                return result;
            }

            // - - - Shape tree root for layer: icon
            // - - ShapeGroup: Group 2
            CanvasGeometry Geometry_0()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(0F, -80F));
                    builder.AddCubicBezier(new Vector2(44.1829987F, -80F), new Vector2(80F, -44.1829987F), new Vector2(80F, 0F));
                    builder.AddCubicBezier(new Vector2(80F, 44.1829987F), new Vector2(44.1829987F, 80F), new Vector2(0F, 80F));
                    builder.AddCubicBezier(new Vector2(-44.1829987F, 80F), new Vector2(-80F, 44.1829987F), new Vector2(-80F, 0F));
                    builder.AddCubicBezier(new Vector2(-80F, -44.1829987F), new Vector2(-44.1829987F, -80F), new Vector2(0F, -80F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            CanvasGeometry Geometry_1()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.BeginFigure(new Vector2(25.0030003F, 43.3009987F));
                    builder.AddCubicBezier(new Vector2(21.5949993F, 45.2229996F), new Vector2(12.3579998F, 50.0089989F), new Vector2(0F, 50.0089989F));
                    builder.AddCubicBezier(new Vector2(-27.5480003F, 50.0089989F), new Vector2(-50F, 27.6229992F), new Vector2(-50F, 0F));
                    builder.AddCubicBezier(new Vector2(-50F, -27.6229992F), new Vector2(-27.6000004F, -50.0089989F), new Vector2(0F, -50.0009995F));
                    builder.AddCubicBezier(new Vector2(27.6000004F, -49.9920006F), new Vector2(50F, -27.6739998F), new Vector2(50F, 0F));
                    builder.AddCubicBezier(new Vector2(50F, 6.59899998F), new Vector2(46.1559982F, 20F), new Vector2(35F, 20F));
                    builder.AddCubicBezier(new Vector2(23.8439999F, 20F), new Vector2(20F, 8.04199982F), new Vector2(20F, 0F));
                    builder.AddCubicBezier(new Vector2(20F, -8.04199982F), new Vector2(11.0459995F, -20F), new Vector2(0F, -20F));
                    builder.AddCubicBezier(new Vector2(-11.0459995F, -20F), new Vector2(-20F, -11.0459995F), new Vector2(-20F, 0F));
                    builder.AddCubicBezier(new Vector2(-20F, 11.0459995F), new Vector2(-11.0459995F, 20F), new Vector2(0F, 20F));
                    builder.AddCubicBezier(new Vector2(10.7539997F, 20F), new Vector2(19.5249996F, 11.5129995F), new Vector2(19.9810009F, 0.871999979F));
                    builder.EndFigure(CanvasFigureLoop.Open);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - Shape tree root for layer: icon
            // - ShapeGroup: Group 1
            // Color
            ColorKeyFrameAnimation ColorAnimation_White_to_SemiTransparentWhite()
            {
                // Frame 0.
                var result = CreateColorKeyFrameAnimation(0F, Color.FromArgb(0xFF, 0xFF, 0xFF, 0xFF), StepThenHoldEasingFunction());
                // Frame 3.
                // White
                result.InsertKeyFrame(0.100000001F, Color.FromArgb(0xFF, 0xFF, 0xFF, 0xFF), _holdThenStepEasingFunction);
                // Frame 11.
                // SemiTransparentWhite
                result.InsertKeyFrame(0.366666675F, Color.FromArgb(0x02, 0xFF, 0xFF, 0xFF), _cubicBezierEasingFunction_0);
                return result;
            }

            // - Shape tree root for layer: icon
            // ShapeGroup: Group 1
            CompositionColorBrush AnimatedColorBrush_White_to_SemiTransparentWhite()
            {
                var result = _c.CreateColorBrush();
                StartProgressBoundAnimation(result, "Color", ColorAnimation_White_to_SemiTransparentWhite(), _rootProgress);
                return result;
            }

            // - Shape tree root for layer: icon
            // ShapeGroup: Group 2
            CompositionColorBrush ColorBrush_AlmostSkyBlue_FF6ABEE2()
            {
                return _c.CreateColorBrush(Color.FromArgb(0xFF, 0x6A, 0xBE, 0xE2));
            }

            // - Shape tree root for layer: icon
            // ShapeGroup: Group 3 Offset:<100, 100>
            CompositionColorBrush ColorBrush_White()
            {
                return _c.CreateColorBrush(Color.FromArgb(0xFF, 0xFF, 0xFF, 0xFF));
            }

            CompositionPath Path()
            {
                var result = _path = new CompositionPath(Geometry_1());
                return result;
            }

            // - Shape tree root for layer: icon
            // ShapeGroup: Group 2
            CompositionPathGeometry PathGeometry_0()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_0()));
            }

            // - Shape tree root for layer: icon
            // ShapeGroup: Group 1
            CompositionPathGeometry PathGeometry_1()
            {
                return _c.CreatePathGeometry(Path());
            }

            // - Shape tree root for layer: icon
            // ShapeGroup: Group 3 Offset:<100, 100>
            CompositionPathGeometry PathGeometry_2()
            {
                var result = _c.CreatePathGeometry(_path);
                StartProgressBoundAnimation(result, "TrimStart", TrimStartScalarAnimation_1_to_0(), _rootProgress);
                return result;
            }

            // Shape tree root for layer: icon
            // Path 1
            CompositionSpriteShape SpriteShape_0()
            {
                var result = _c.CreateSpriteShape(PathGeometry_0());
                result.Offset = new Vector2(100F, 100F);
                result.FillBrush = ColorBrush_AlmostSkyBlue_FF6ABEE2();
                StartProgressBoundAnimation(result, "Scale", ScaleVector2Animation_0(), RootProgress());
                return result;
            }

            // Shape tree root for layer: icon
            // Path 1
            CompositionSpriteShape SpriteShape_1()
            {
                var result = _c.CreateSpriteShape(PathGeometry_1());
                result.Offset = new Vector2(100F, 100F);
                result.StrokeBrush = AnimatedColorBrush_White_to_SemiTransparentWhite();
                result.StrokeDashCap = CompositionStrokeCap.Round;
                result.StrokeStartCap = CompositionStrokeCap.Round;
                result.StrokeEndCap = CompositionStrokeCap.Round;
                result.StrokeMiterLimit = 5F;
                StartProgressBoundAnimation(result, "StrokeThickness", StrokeThicknessScalarAnimation_10_to_0(), _rootProgress);
                StartProgressBoundAnimation(result, "Scale", ScaleVector2Animation_1(), _rootProgress);
                return result;
            }

            // Shape tree root for layer: icon
            // Path 1
            CompositionSpriteShape SpriteShape_2()
            {
                // Offset:<100, 100>
                var result = CreateSpriteShape(PathGeometry_2(), new Matrix3x2(1F, 0F, 0F, 1F, 100F, 100F));
                result.StrokeBrush = ColorBrush_White();
                result.StrokeDashCap = CompositionStrokeCap.Round;
                result.StrokeStartCap = CompositionStrokeCap.Round;
                result.StrokeEndCap = CompositionStrokeCap.Round;
                result.StrokeMiterLimit = 5F;
                result.StrokeThickness = 10F;
                return result;
            }

            // The root of the composition.
            ContainerVisual Root()
            {
                var result = _root = _c.CreateContainerVisual();
                var propertySet = result.Properties;
                propertySet.InsertScalar("Progress", 0F);
                // Shape tree root for layer: icon
                result.Children.InsertAtTop(ShapeVisual_0());
                return result;
            }

            CubicBezierEasingFunction CubicBezierEasingFunction_0()
            {
                return _cubicBezierEasingFunction_0 = _c.CreateCubicBezierEasingFunction(new Vector2(0.600000024F, 0F), new Vector2(0.400000006F, 1F));
            }

            ExpressionAnimation RootProgress()
            {
                var result = _rootProgress = _c.CreateExpressionAnimation("_.Progress");
                result.SetReferenceParameter("_", _root);
                return result;
            }

            // - Shape tree root for layer: icon
            // ShapeGroup: Group 1
            // StrokeThickness
            ScalarKeyFrameAnimation StrokeThicknessScalarAnimation_10_to_0()
            {
                // Frame 0.
                var result = CreateScalarKeyFrameAnimation(0F, 10F, _stepThenHoldEasingFunction);
                // Frame 3.
                result.InsertKeyFrame(0.100000001F, 10F, _holdThenStepEasingFunction);
                // Frame 11.
                result.InsertKeyFrame(0.366666675F, 0F, _cubicBezierEasingFunction_0);
                return result;
            }

            // - - Shape tree root for layer: icon
            // - ShapeGroup: Group 3 Offset:<100, 100>
            // TrimStart
            ScalarKeyFrameAnimation TrimStartScalarAnimation_1_to_0()
            {
                // Frame 0.
                var result = CreateScalarKeyFrameAnimation(0F, 1F, _stepThenHoldEasingFunction);
                // Frame 10.
                result.InsertKeyFrame(0.333333343F, 1F, _holdThenStepEasingFunction);
                // Frame 29.
                result.InsertKeyFrame(0.966666639F, 0F, _c.CreateCubicBezierEasingFunction(new Vector2(0.166999996F, 0.166999996F), new Vector2(0.400000006F, 1F)));
                return result;
            }

            // Shape tree root for layer: icon
            ShapeVisual ShapeVisual_0()
            {
                var result = _c.CreateShapeVisual();
                result.Size = new Vector2(200F, 200F);
                var shapes = result.Shapes;
                // ShapeGroup: Group 2
                shapes.Add(SpriteShape_0());
                // ShapeGroup: Group 1
                shapes.Add(SpriteShape_1());
                // ShapeGroup: Group 3 Offset:<100, 100>
                shapes.Add(SpriteShape_2());
                return result;
            }

            StepEasingFunction HoldThenStepEasingFunction()
            {
                var result = _holdThenStepEasingFunction = _c.CreateStepEasingFunction();
                result.IsFinalStepSingleFrame = true;
                return result;
            }

            StepEasingFunction StepThenHoldEasingFunction()
            {
                var result = _stepThenHoldEasingFunction = _c.CreateStepEasingFunction();
                result.IsInitialStepSingleFrame = true;
                return result;
            }

            // - Shape tree root for layer: icon
            // ShapeGroup: Group 2
            // Scale
            Vector2KeyFrameAnimation ScaleVector2Animation_0()
            {
                // Frame 0.
                var result = CreateVector2KeyFrameAnimation(0F, new Vector2(1F, 1F), HoldThenStepEasingFunction());
                // Frame 8.
                result.InsertKeyFrame(0.266666681F, new Vector2(1.12F, 1.12F), CubicBezierEasingFunction_0());
                // Frame 16.
                result.InsertKeyFrame(0.533333361F, new Vector2(0.949999988F, 0.949999988F), _cubicBezierEasingFunction_0);
                // Frame 24.
                result.InsertKeyFrame(0.800000012F, new Vector2(1F, 1F), _cubicBezierEasingFunction_0);
                return result;
            }

            // - Shape tree root for layer: icon
            // ShapeGroup: Group 1
            // Scale
            Vector2KeyFrameAnimation ScaleVector2Animation_1()
            {
                // Frame 0.
                var result = CreateVector2KeyFrameAnimation(0F, new Vector2(1F, 1F), _stepThenHoldEasingFunction);
                // Frame 3.
                result.InsertKeyFrame(0.100000001F, new Vector2(1F, 1F), _holdThenStepEasingFunction);
                // Frame 11.
                result.InsertKeyFrame(0.366666675F, new Vector2(1.55999994F, 1.55999994F), _cubicBezierEasingFunction_0);
                return result;
            }

            internal Username_AnimatedVisual(
                Compositor compositor
                )
            {
                _c = compositor;
                _reusableExpressionAnimation = compositor.CreateExpressionAnimation();
                Root();
            }

            public Visual RootVisual => _root;
            public TimeSpan Duration => TimeSpan.FromTicks(c_durationTicks);
            public Vector2 Size => new Vector2(200F, 200F);
            void IDisposable.Dispose() => _root?.Dispose();

            internal static bool IsRuntimeCompatible()
            {
                return Windows.Foundation.Metadata.ApiInformation.IsApiContractPresent("Windows.Foundation.UniversalApiContract", 7);
            }
        }
    }
}
