using Grasshopper.Kernel;
using Rhino.Geometry;
using System;
using System.Collections.Generic;

// In order to load the result of this wizard, you will also need to
// add the output bin/ folder of this project to the list of loaded
// folder in Grasshopper.
// You can use the _GrasshopperDeveloperSettings Rhino command for that.

namespace C41_Utilities
{
    public class C41UtilitiesComponent : GH_Component
    {
        /// <summary>
        /// Each implementation of GH_Component must provide a public 
        /// constructor without any arguments.
        /// Category represents the Tab in which the component will appear, 
        /// Subcategory the panel. If you use non-existing tab or panel names, 
        /// new tabs/panels will automatically be created.
        /// </summary>
        public C41UtilitiesComponent()
          : base("C41_Utilities", "C41_Utilities",
              "Utilities",
              "C41", "Pattern")
        {
        }

        /// <summary>
        /// Registers all the input parameters for this component.
        /// </summary>
        protected override void RegisterInputParams(GH_Component.GH_InputParamManager pManager)
        {
            pManager.AddCurveParameter("Attractor", "A", "The Curve used as and attractor", GH_ParamAccess.item);
            pManager.AddGeometryParameter("Pattern", "P", "The Pattern to Repeat", GH_ParamAccess.list);
        }

        /// <summary>
        /// Registers all the output parameters for this component.
        /// </summary>
        protected override void RegisterOutputParams(GH_Component.GH_OutputParamManager pManager)
        {
            pManager.AddTextParameter("Out", "O", "Output Pattern as a list", GH_ParamAccess.list);
        }

        /// <summary>
        /// This is the method that actually does the work.
        /// </summary>
        /// <param name="DA">The DA object can be used to retrieve data from input parameters and 
        /// to store data in output parameters.</param>
        protected override void SolveInstance(IGH_DataAccess DA)
        {

            //Hello
        }

        /// <summary>
        /// Provides an Icon for every component that will be visible in the User Interface.
        /// Icons need to be 24x24 pixels.
        /// </summary>
        protected override System.Drawing.Bitmap Icon
        {
            get
            {
                return Properties.Resources.IconC41;
                //return null;
            }
        }

        /// <summary>
        /// Each component must have a unique Guid to identify it. 
        /// It is vital this Guid doesn't change otherwise old ghx files 
        /// that use the old ID will partially fail during loading.
        /// </summary>
        public override Guid ComponentGuid
        {
            get { return new Guid("5ad84cd3-e499-49bf-a63c-6b123913e920"); }
        }

        // Main Operation

        List<Point3d> grid;
        List<Polyline> pattern;

        public List<double> ExtractGrid(Polyline pl)
        {
            double angle = Vector3d.VectorAngle(new Vector3d(pl[0] - pl[1]), new Vector3d(pl[2] - pl[1]));

            double gridX = pl[0].DistanceTo(pl[1]);
            double gridY = pl[2].Y;

            if (Math.Abs(angle - (Math.PI * 0.5)) > 0.1)
            {
                double gridXX = new Vector3d(pl[2] - pl[1]).X;
                return new List<double> { gridX, gridY, gridXX };
            }

            else
            {
                return new List<double> { gridX, gridY };
            }
        }

    }
}
