﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//       LottieGen version:
//           7.1.0+ge1fa92580f
//       
//       Command:
//           LottieGen -Language CSharp -Namespace Unigram.Assets.Icons -Public -WinUIVersion 2.7 -InputFile Data.json
//       
//       Input file:
//           Data.json (3780 bytes created 17:41+01:00 Dec 21 2021)
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
// | All CompositionObjects   |    42 |
// |--------------------------+-------|
// | Expression animators     |     3 |
// | KeyFrame animators       |     3 |
// | Reference parameters     |     3 |
// | Expression operations    |     0 |
// |--------------------------+-------|
// | Animated brushes         |     - |
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
    // Name:        u_database
    // Frame rate:  60 fps
    // Frame count: 30
    // Duration:    500.0 mS
    sealed class Data
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

            if (Data_AnimatedVisual.IsRuntimeCompatible())
            {
                return
                    new Data_AnimatedVisual(
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

        sealed class Data_AnimatedVisual : Microsoft.UI.Xaml.Controls.IAnimatedVisual
        {
            const long c_durationTicks = 5000000;
            readonly Compositor _c;
            readonly ExpressionAnimation _reusableExpressionAnimation;
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

            Vector2KeyFrameAnimation CreateVector2KeyFrameAnimation(float initialProgress, Vector2 initialValue, CompositionEasingFunction initialEasingFunction)
            {
                var result = _c.CreateVector2KeyFrameAnimation();
                result.Duration = TimeSpan.FromTicks(c_durationTicks);
                result.InsertKeyFrame(initialProgress, initialValue, initialEasingFunction);
                return result;
            }

            // - - - Shape tree root for layer: icon
            // - - ShapeGroup: Group 3
            CanvasGeometry Geometry_0()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(0F, -20F));
                    builder.AddCubicBezier(new Vector2(33.137001F, -20F), new Vector2(60F, -33.4319992F), new Vector2(60F, -50F));
                    builder.AddCubicBezier(new Vector2(60F, -66.5680008F), new Vector2(33.137001F, -80F), new Vector2(0F, -80F));
                    builder.AddCubicBezier(new Vector2(-33.137001F, -80F), new Vector2(-60F, -66.5680008F), new Vector2(-60F, -50F));
                    builder.AddCubicBezier(new Vector2(-60F, -33.4319992F), new Vector2(-33.137001F, -20F), new Vector2(0F, -20F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - Shape tree root for layer: icon
            // - - ShapeGroup: Group 2
            CanvasGeometry Geometry_1()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(46.8989983F, -19.8430004F));
                    builder.AddCubicBezier(new Vector2(51.5929985F, -22.1900005F), new Vector2(56.1730003F, -25.177F), new Vector2(60F, -28.7970009F));
                    builder.AddLine(new Vector2(60F, 0F));
                    builder.AddCubicBezier(new Vector2(60F, 16.5680008F), new Vector2(33.137001F, 30F), new Vector2(0F, 30F));
                    builder.AddCubicBezier(new Vector2(-33.137001F, 30F), new Vector2(-60F, 16.5680008F), new Vector2(-60F, 0F));
                    builder.AddLine(new Vector2(-60F, -28.7970009F));
                    builder.AddCubicBezier(new Vector2(-56.1730003F, -25.177F), new Vector2(-51.5929985F, -22.1900005F), new Vector2(-46.8979988F, -19.8430004F));
                    builder.AddCubicBezier(new Vector2(-34.3790016F, -13.5830002F), new Vector2(-17.7840004F, -10F), new Vector2(0F, -10F));
                    builder.AddCubicBezier(new Vector2(17.7840004F, -10F), new Vector2(34.3790016F, -13.5830002F), new Vector2(46.8989983F, -19.8430004F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - Shape tree root for layer: icon
            // - - ShapeGroup: Group 1
            CanvasGeometry Geometry_2()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(46.8989983F, 30.1569996F));
                    builder.AddCubicBezier(new Vector2(51.5929985F, 27.8099995F), new Vector2(56.1730003F, 24.823F), new Vector2(60F, 21.2029991F));
                    builder.AddLine(new Vector2(60F, 50F));
                    builder.AddCubicBezier(new Vector2(60F, 66.5680008F), new Vector2(33.137001F, 80F), new Vector2(0F, 80F));
                    builder.AddCubicBezier(new Vector2(-33.137001F, 80F), new Vector2(-60F, 66.5680008F), new Vector2(-60F, 50F));
                    builder.AddLine(new Vector2(-60F, 21.2029991F));
                    builder.AddCubicBezier(new Vector2(-56.1730003F, 24.823F), new Vector2(-51.5929985F, 27.8099995F), new Vector2(-46.8979988F, 30.1569996F));
                    builder.AddCubicBezier(new Vector2(-34.3790016F, 36.4169998F), new Vector2(-17.7840004F, 40F), new Vector2(0F, 40F));
                    builder.AddCubicBezier(new Vector2(17.7840004F, 40F), new Vector2(34.3790016F, 36.4169998F), new Vector2(46.8989983F, 30.1569996F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - Shape tree root for layer: icon
            // ShapeGroup: Group 2
            CompositionColorBrush ColorBrush_AlmostCornflowerBlue_FF4290D9()
            {
                return _c.CreateColorBrush(Color.FromArgb(0xFF, 0x42, 0x90, 0xD9));
            }

            // - Shape tree root for layer: icon
            // ShapeGroup: Group 1
            CompositionColorBrush ColorBrush_AlmostDarkSlateBlue_FF27589F()
            {
                return _c.CreateColorBrush(Color.FromArgb(0xFF, 0x27, 0x58, 0x9F));
            }

            // - Shape tree root for layer: icon
            // ShapeGroup: Group 3
            CompositionColorBrush ColorBrush_AlmostSkyBlue_FF6AC8F0()
            {
                return _c.CreateColorBrush(Color.FromArgb(0xFF, 0x6A, 0xC8, 0xF0));
            }

            // - Shape tree root for layer: icon
            // ShapeGroup: Group 3
            CompositionPathGeometry PathGeometry_0()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_0()));
            }

            // - Shape tree root for layer: icon
            // ShapeGroup: Group 2
            CompositionPathGeometry PathGeometry_1()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_1()));
            }

            // - Shape tree root for layer: icon
            // ShapeGroup: Group 1
            CompositionPathGeometry PathGeometry_2()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_2()));
            }

            // Shape tree root for layer: icon
            // Path 1
            CompositionSpriteShape SpriteShape_0()
            {
                var result = _c.CreateSpriteShape(PathGeometry_0());
                result.Offset = new Vector2(100F, 100F);
                result.FillBrush = ColorBrush_AlmostSkyBlue_FF6AC8F0();
                StartProgressBoundAnimation(result, "Scale", ScaleVector2Animation_0(), RootProgress());
                return result;
            }

            // Shape tree root for layer: icon
            // Path 1
            CompositionSpriteShape SpriteShape_1()
            {
                var result = _c.CreateSpriteShape(PathGeometry_1());
                result.Offset = new Vector2(100F, 100F);
                result.FillBrush = ColorBrush_AlmostCornflowerBlue_FF4290D9();
                StartProgressBoundAnimation(result, "Scale", ScaleVector2Animation_1(), _rootProgress);
                return result;
            }

            // Shape tree root for layer: icon
            // Path 1
            CompositionSpriteShape SpriteShape_2()
            {
                var result = _c.CreateSpriteShape(PathGeometry_2());
                result.Offset = new Vector2(100F, 100F);
                result.FillBrush = ColorBrush_AlmostDarkSlateBlue_FF27589F();
                StartProgressBoundAnimation(result, "Scale", ScaleVector2Animation_2(), _rootProgress);
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

            // Shape tree root for layer: icon
            ShapeVisual ShapeVisual_0()
            {
                var result = _c.CreateShapeVisual();
                result.Size = new Vector2(200F, 200F);
                var shapes = result.Shapes;
                // ShapeGroup: Group 3
                shapes.Add(SpriteShape_0());
                // ShapeGroup: Group 2
                shapes.Add(SpriteShape_1());
                // ShapeGroup: Group 1
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
            // ShapeGroup: Group 3
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
            // ShapeGroup: Group 2
            // Scale
            Vector2KeyFrameAnimation ScaleVector2Animation_1()
            {
                // Frame 0.
                var result = CreateVector2KeyFrameAnimation(0F, new Vector2(1F, 1F), StepThenHoldEasingFunction());
                // Frame 3.
                result.InsertKeyFrame(0.100000001F, new Vector2(1F, 1F), _holdThenStepEasingFunction);
                // Frame 11.
                result.InsertKeyFrame(0.366666675F, new Vector2(1.12F, 1.12F), _cubicBezierEasingFunction_0);
                // Frame 19.
                result.InsertKeyFrame(0.633333325F, new Vector2(0.949999988F, 0.949999988F), _cubicBezierEasingFunction_0);
                // Frame 27.
                result.InsertKeyFrame(0.899999976F, new Vector2(1F, 1F), _cubicBezierEasingFunction_0);
                return result;
            }

            // - Shape tree root for layer: icon
            // ShapeGroup: Group 1
            // Scale
            Vector2KeyFrameAnimation ScaleVector2Animation_2()
            {
                // Frame 0.
                var result = CreateVector2KeyFrameAnimation(0F, new Vector2(1F, 1F), _stepThenHoldEasingFunction);
                // Frame 6.
                result.InsertKeyFrame(0.200000003F, new Vector2(1F, 1F), _holdThenStepEasingFunction);
                // Frame 14.
                result.InsertKeyFrame(0.466666669F, new Vector2(1.12F, 1.12F), _cubicBezierEasingFunction_0);
                // Frame 22.
                result.InsertKeyFrame(0.733333349F, new Vector2(0.949999988F, 0.949999988F), _cubicBezierEasingFunction_0);
                // Frame 29.
                result.InsertKeyFrame(0.966666639F, new Vector2(1F, 1F), _cubicBezierEasingFunction_0);
                return result;
            }

            internal Data_AnimatedVisual(
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
