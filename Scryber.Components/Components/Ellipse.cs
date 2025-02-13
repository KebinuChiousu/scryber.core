﻿/*  Copyright 2012 PerceiveIT Limited
 *  This file is part of the Scryber library.
 *
 *  You can redistribute Scryber and/or modify 
 *  it under the terms of the GNU Lesser General Public License as published by
 *  the Free Software Foundation, either version 3 of the License, or
 *  (at your option) any later version.
 * 
 *  Scryber is distributed in the hope that it will be useful,
 *  but WITHOUT ANY WARRANTY; without even the implied warranty of
 *  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *  GNU Lesser General Public License for more details.
 * 
 *  You should have received a copy of the GNU Lesser General Public License
 *  along with Scryber source code in the COPYING.txt file.  If not, see <http://www.gnu.org/licenses/>.
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Scryber.Styles;
using Scryber.Components;
using Scryber.Drawing;

namespace Scryber.Components
{

    [PDFParsableComponent("Ellipse")]
    public class Ellipse : PolygonBase
    {

        public Ellipse()
            : this(PDFObjectTypes.ShapeElipse)
        {
        }

        public Ellipse(PDFObjectType type)
            : base(type)
        {
            this.DefaultRotation = 0;
        }



        protected override PDFGraphicsPath CreatePath(PDFSize available, Style fullstyle)
        {
            PDFRect bounds = GetPrescribedBounds(available, fullstyle);
            StyleValue<bool> isclosed;
            StyleValue<double> rotation;
            fullstyle.TryGetValue(StyleKeys.ShapeClosedKey, out isclosed);
            fullstyle.TryGetValue(StyleKeys.ShapeRotationKey, out rotation);
            PDFGraphicsPath path = new PDFGraphicsPath();
            BuildElipse(path, bounds,
                                (isclosed == null)? true : isclosed.Value(fullstyle), 
                                ((rotation == null)? 0.0 : rotation.Value(fullstyle)) + this.DefaultRotation);

            return path;
        }


        //used for calculating the handle points of a bezier curve to approximage an arc
        public const double CircularityFactor = 0.5522847498;

        public static void BuildElipse(PDFGraphicsPath path, PDFRect rect, bool closed, double angle)
        {

            double width = rect.Width.PointsValue;
            double height = rect.Height.PointsValue;

            if (width <= 0 || height <= 0)
                return;

            // build the ellipse around the origin
            // rotate each by the required amount
            // then translate into position.

            double centerX = rect.Width.PointsValue / 2.0;
            double centerY = rect.Height.PointsValue / 2.0;

            double radX = width / 2.0;
            double radY = height / 2.0;

            double lengthX = (double)((width * CircularityFactor) / 2.0);
            double lengthY = (double)((height * CircularityFactor) / 2.0);

            double rotation = angle * InRadians;

            //start at left, middle
            PDFPoint start = Rotate(new PDFPoint(-radX, 0), rotation);


            //4 curve definitions with 3 points each.
            PDFPoint[,] curves = new PDFPoint[4, 3];


            //arc to center, top
            curves[0, 0] = Rotate(new PDFPoint(0, -radY), rotation);
            curves[0, 1] = Rotate(new PDFPoint(-radX, -lengthY), rotation);
            curves[0, 2] = Rotate(new PDFPoint(-lengthX, -radY), rotation);



            //arc to right, middle
            curves[1, 0] = Rotate(new PDFPoint(radX, 0), rotation);
            curves[1, 1] = Rotate(new PDFPoint(lengthX, -radY), rotation);
            curves[1, 2] = Rotate(new PDFPoint(radX, -lengthY), rotation);


            //arc to center, bottom
            curves[2, 0] = Rotate(new PDFPoint(0, radY), rotation);
            curves[2, 1] = Rotate(new PDFPoint(radX, lengthY), rotation);
            curves[2, 2] = Rotate(new PDFPoint(lengthX, radY), rotation);


            //arc to left middle
            curves[3, 0] = Rotate(new PDFPoint(-radX, 0), rotation);
            curves[3, 1] = Rotate(new PDFPoint(-lengthX, radY), rotation);
            curves[3, 2] = Rotate(new PDFPoint(-radX, lengthY), rotation);

            //get the minimun x and y values
            PDFUnit minx = start.X;
            PDFUnit miny = start.Y;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    PDFPoint pt = curves[i, j];
                    minx = PDFUnit.Min(minx, pt.X);
                    miny = PDFUnit.Min(miny, pt.Y);
                }

            }
            PDFUnit offsetx = 0 - minx;
            PDFUnit offsety = 0 - miny;

            //translate the point by the minimum values so the topleft is always 0,0 in the boundary rect.

            start = Translate(start, offsetx, offsety);

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    PDFPoint pt = curves[i, j];
                    pt = Translate(pt, offsetx, offsety);
                    curves[i, j] = pt;
                }
            }

            path.MoveTo(start);
            path.CubicCurveTo(curves[0, 0], curves[0, 1], curves[0, 2]);
            path.CubicCurveTo(curves[1, 0], curves[1, 1], curves[1, 2]);
            path.CubicCurveTo(curves[2, 0], curves[2, 1], curves[2, 2]);
            path.CubicCurveTo(curves[3, 0], curves[3, 1], curves[3, 2]);



            //close
            if (closed)
                path.ClosePath(true);
            else
                path.EndPath();
        }



        //
        // not needed or implemented
        //

        protected override PDFPoint[] GetPoints(PDFRect bounds, Style style)
        {
            throw new NotImplementedException();
        }
    }
}
