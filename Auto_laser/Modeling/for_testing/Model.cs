/*
* MATLAB Compiler: 6.5 (R2017b)
* Date: Thu Dec 19 13:02:22 2019
* Arguments:
* "-B""macro_default""-W""dotnet:Modeling,Model,4.0,private""-T""link:lib""-d""F:\old_lase
* r_change\Auto_laser\Modeling\for_testing""-v""class{Model:F:\old_laser_change\室内实验\M
* odeling.m}"
*/
using System;
using System.Reflection;
using System.IO;
using MathWorks.MATLAB.NET.Arrays;
using MathWorks.MATLAB.NET.Utility;

#if SHARED
[assembly: System.Reflection.AssemblyKeyFile(@"")]
#endif

namespace Modeling
{

  /// <summary>
  /// The Model class provides a CLS compliant, MWArray interface to the MATLAB functions
  /// contained in the files:
  /// <newpara></newpara>
  /// F:\old_laser_change\室内实验\Modeling.m
  /// </summary>
  /// <remarks>
  /// @Version 4.0
  /// </remarks>
  public class Model : IDisposable
  {
    #region Constructors

    /// <summary internal= "true">
    /// The static constructor instantiates and initializes the MATLAB Runtime instance.
    /// </summary>
    static Model()
    {
      if (MWMCR.MCRAppInitialized)
      {
        try
        {
          Assembly assembly= Assembly.GetExecutingAssembly();

          string ctfFilePath= assembly.Location;

          int lastDelimiter= ctfFilePath.LastIndexOf(@"\");

          ctfFilePath= ctfFilePath.Remove(lastDelimiter, (ctfFilePath.Length - lastDelimiter));

          string ctfFileName = "Modeling.ctf";

          Stream embeddedCtfStream = null;

          String[] resourceStrings = assembly.GetManifestResourceNames();

          foreach (String name in resourceStrings)
          {
            if (name.Contains(ctfFileName))
            {
              embeddedCtfStream = assembly.GetManifestResourceStream(name);
              break;
            }
          }
          mcr= new MWMCR("",
                         ctfFilePath, embeddedCtfStream, true);
        }
        catch(Exception ex)
        {
          ex_ = new Exception("MWArray assembly failed to be initialized", ex);
        }
      }
      else
      {
        ex_ = new ApplicationException("MWArray assembly could not be initialized");
      }
    }


    /// <summary>
    /// Constructs a new instance of the Model class.
    /// </summary>
    public Model()
    {
      if(ex_ != null)
      {
        throw ex_;
      }
    }


    #endregion Constructors

    #region Finalize

    /// <summary internal= "true">
    /// Class destructor called by the CLR garbage collector.
    /// </summary>
    ~Model()
    {
      Dispose(false);
    }


    /// <summary>
    /// Frees the native resources associated with this object
    /// </summary>
    public void Dispose()
    {
      Dispose(true);

      GC.SuppressFinalize(this);
    }


    /// <summary internal= "true">
    /// Internal dispose function
    /// </summary>
    protected virtual void Dispose(bool disposing)
    {
      if (!disposed)
      {
        disposed= true;

        if (disposing)
        {
          // Free managed resources;
        }

        // Free native resources
      }
    }


    #endregion Finalize

    #region Methods

    /// <summary>
    /// Provides a single output, 0-input MWArrayinterface to the Modeling MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// clear all;
    /// A='a';B='a';C='a';D='a';E='a';   
    /// txt_num=input('请输入文件序号的值:');        
    /// 手动输入的地图序号,这个现在不知道在干啥，后面建模的时候好像没有用到
    /// modeling_num=input('请输入地图序号的值:');    手动输入的建模次数
    /// </remarks>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray Modeling()
    {
      return mcr.EvaluateFunction("Modeling", new MWArray[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input MWArrayinterface to the Modeling MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// clear all;
    /// A='a';B='a';C='a';D='a';E='a';   
    /// txt_num=input('请输入文件序号的值:');        
    /// 手动输入的地图序号,这个现在不知道在干啥，后面建模的时候好像没有用到
    /// modeling_num=input('请输入地图序号的值:');    手动输入的建模次数
    /// </remarks>
    /// <param name="m">Input argument #1</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray Modeling(MWArray m)
    {
      return mcr.EvaluateFunction("Modeling", m);
    }


    /// <summary>
    /// Provides a single output, 2-input MWArrayinterface to the Modeling MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// clear all;
    /// A='a';B='a';C='a';D='a';E='a';   
    /// txt_num=input('请输入文件序号的值:');        
    /// 手动输入的地图序号,这个现在不知道在干啥，后面建模的时候好像没有用到
    /// modeling_num=input('请输入地图序号的值:');    手动输入的建模次数
    /// </remarks>
    /// <param name="m">Input argument #1</param>
    /// <param name="modeling_num">Input argument #2</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray Modeling(MWArray m, MWArray modeling_num)
    {
      return mcr.EvaluateFunction("Modeling", m, modeling_num);
    }


    /// <summary>
    /// Provides a single output, 3-input MWArrayinterface to the Modeling MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// clear all;
    /// A='a';B='a';C='a';D='a';E='a';   
    /// txt_num=input('请输入文件序号的值:');        
    /// 手动输入的地图序号,这个现在不知道在干啥，后面建模的时候好像没有用到
    /// modeling_num=input('请输入地图序号的值:');    手动输入的建模次数
    /// </remarks>
    /// <param name="m">Input argument #1</param>
    /// <param name="modeling_num">Input argument #2</param>
    /// <param name="imu">Input argument #3</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray Modeling(MWArray m, MWArray modeling_num, MWArray imu)
    {
      return mcr.EvaluateFunction("Modeling", m, modeling_num, imu);
    }


    /// <summary>
    /// Provides a single output, 4-input MWArrayinterface to the Modeling MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// clear all;
    /// A='a';B='a';C='a';D='a';E='a';   
    /// txt_num=input('请输入文件序号的值:');        
    /// 手动输入的地图序号,这个现在不知道在干啥，后面建模的时候好像没有用到
    /// modeling_num=input('请输入地图序号的值:');    手动输入的建模次数
    /// </remarks>
    /// <param name="m">Input argument #1</param>
    /// <param name="modeling_num">Input argument #2</param>
    /// <param name="imu">Input argument #3</param>
    /// <param name="TR_in1">Input argument #4</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray Modeling(MWArray m, MWArray modeling_num, MWArray imu, MWArray TR_in1)
    {
      return mcr.EvaluateFunction("Modeling", m, modeling_num, imu, TR_in1);
    }


    /// <summary>
    /// Provides a single output, 5-input MWArrayinterface to the Modeling MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// clear all;
    /// A='a';B='a';C='a';D='a';E='a';   
    /// txt_num=input('请输入文件序号的值:');        
    /// 手动输入的地图序号,这个现在不知道在干啥，后面建模的时候好像没有用到
    /// modeling_num=input('请输入地图序号的值:');    手动输入的建模次数
    /// </remarks>
    /// <param name="m">Input argument #1</param>
    /// <param name="modeling_num">Input argument #2</param>
    /// <param name="imu">Input argument #3</param>
    /// <param name="TR_in1">Input argument #4</param>
    /// <param name="TT_in1">Input argument #5</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray Modeling(MWArray m, MWArray modeling_num, MWArray imu, MWArray TR_in1, 
                      MWArray TT_in1)
    {
      return mcr.EvaluateFunction("Modeling", m, modeling_num, imu, TR_in1, TT_in1);
    }


    /// <summary>
    /// Provides a single output, 6-input MWArrayinterface to the Modeling MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// clear all;
    /// A='a';B='a';C='a';D='a';E='a';   
    /// txt_num=input('请输入文件序号的值:');        
    /// 手动输入的地图序号,这个现在不知道在干啥，后面建模的时候好像没有用到
    /// modeling_num=input('请输入地图序号的值:');    手动输入的建模次数
    /// </remarks>
    /// <param name="m">Input argument #1</param>
    /// <param name="modeling_num">Input argument #2</param>
    /// <param name="imu">Input argument #3</param>
    /// <param name="TR_in1">Input argument #4</param>
    /// <param name="TT_in1">Input argument #5</param>
    /// <param name="XYZ_total_in1">Input argument #6</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray Modeling(MWArray m, MWArray modeling_num, MWArray imu, MWArray TR_in1, 
                      MWArray TT_in1, MWArray XYZ_total_in1)
    {
      return mcr.EvaluateFunction("Modeling", m, modeling_num, imu, TR_in1, TT_in1, XYZ_total_in1);
    }


    /// <summary>
    /// Provides a single output, 7-input MWArrayinterface to the Modeling MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// clear all;
    /// A='a';B='a';C='a';D='a';E='a';   
    /// txt_num=input('请输入文件序号的值:');        
    /// 手动输入的地图序号,这个现在不知道在干啥，后面建模的时候好像没有用到
    /// modeling_num=input('请输入地图序号的值:');    手动输入的建模次数
    /// </remarks>
    /// <param name="m">Input argument #1</param>
    /// <param name="modeling_num">Input argument #2</param>
    /// <param name="imu">Input argument #3</param>
    /// <param name="TR_in1">Input argument #4</param>
    /// <param name="TT_in1">Input argument #5</param>
    /// <param name="XYZ_total_in1">Input argument #6</param>
    /// <param name="oppupencyMap_in1">Input argument #7</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray Modeling(MWArray m, MWArray modeling_num, MWArray imu, MWArray TR_in1, 
                      MWArray TT_in1, MWArray XYZ_total_in1, MWArray oppupencyMap_in1)
    {
      return mcr.EvaluateFunction("Modeling", m, modeling_num, imu, TR_in1, TT_in1, XYZ_total_in1, oppupencyMap_in1);
    }


    /// <summary>
    /// Provides a single output, 8-input MWArrayinterface to the Modeling MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// clear all;
    /// A='a';B='a';C='a';D='a';E='a';   
    /// txt_num=input('请输入文件序号的值:');        
    /// 手动输入的地图序号,这个现在不知道在干啥，后面建模的时候好像没有用到
    /// modeling_num=input('请输入地图序号的值:');    手动输入的建模次数
    /// </remarks>
    /// <param name="m">Input argument #1</param>
    /// <param name="modeling_num">Input argument #2</param>
    /// <param name="imu">Input argument #3</param>
    /// <param name="TR_in1">Input argument #4</param>
    /// <param name="TT_in1">Input argument #5</param>
    /// <param name="XYZ_total_in1">Input argument #6</param>
    /// <param name="oppupencyMap_in1">Input argument #7</param>
    /// <param name="bound_old_in1">Input argument #8</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray Modeling(MWArray m, MWArray modeling_num, MWArray imu, MWArray TR_in1, 
                      MWArray TT_in1, MWArray XYZ_total_in1, MWArray oppupencyMap_in1, 
                      MWArray bound_old_in1)
    {
      return mcr.EvaluateFunction("Modeling", m, modeling_num, imu, TR_in1, TT_in1, XYZ_total_in1, oppupencyMap_in1, bound_old_in1);
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the Modeling MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// clear all;
    /// A='a';B='a';C='a';D='a';E='a';   
    /// txt_num=input('请输入文件序号的值:');        
    /// 手动输入的地图序号,这个现在不知道在干啥，后面建模的时候好像没有用到
    /// modeling_num=input('请输入地图序号的值:');    手动输入的建模次数
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] Modeling(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "Modeling", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 1-input MWArray interface to the Modeling MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// clear all;
    /// A='a';B='a';C='a';D='a';E='a';   
    /// txt_num=input('请输入文件序号的值:');        
    /// 手动输入的地图序号,这个现在不知道在干啥，后面建模的时候好像没有用到
    /// modeling_num=input('请输入地图序号的值:');    手动输入的建模次数
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="m">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] Modeling(int numArgsOut, MWArray m)
    {
      return mcr.EvaluateFunction(numArgsOut, "Modeling", m);
    }


    /// <summary>
    /// Provides the standard 2-input MWArray interface to the Modeling MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// clear all;
    /// A='a';B='a';C='a';D='a';E='a';   
    /// txt_num=input('请输入文件序号的值:');        
    /// 手动输入的地图序号,这个现在不知道在干啥，后面建模的时候好像没有用到
    /// modeling_num=input('请输入地图序号的值:');    手动输入的建模次数
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="m">Input argument #1</param>
    /// <param name="modeling_num">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] Modeling(int numArgsOut, MWArray m, MWArray modeling_num)
    {
      return mcr.EvaluateFunction(numArgsOut, "Modeling", m, modeling_num);
    }


    /// <summary>
    /// Provides the standard 3-input MWArray interface to the Modeling MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// clear all;
    /// A='a';B='a';C='a';D='a';E='a';   
    /// txt_num=input('请输入文件序号的值:');        
    /// 手动输入的地图序号,这个现在不知道在干啥，后面建模的时候好像没有用到
    /// modeling_num=input('请输入地图序号的值:');    手动输入的建模次数
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="m">Input argument #1</param>
    /// <param name="modeling_num">Input argument #2</param>
    /// <param name="imu">Input argument #3</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] Modeling(int numArgsOut, MWArray m, MWArray modeling_num, MWArray 
                        imu)
    {
      return mcr.EvaluateFunction(numArgsOut, "Modeling", m, modeling_num, imu);
    }


    /// <summary>
    /// Provides the standard 4-input MWArray interface to the Modeling MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// clear all;
    /// A='a';B='a';C='a';D='a';E='a';   
    /// txt_num=input('请输入文件序号的值:');        
    /// 手动输入的地图序号,这个现在不知道在干啥，后面建模的时候好像没有用到
    /// modeling_num=input('请输入地图序号的值:');    手动输入的建模次数
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="m">Input argument #1</param>
    /// <param name="modeling_num">Input argument #2</param>
    /// <param name="imu">Input argument #3</param>
    /// <param name="TR_in1">Input argument #4</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] Modeling(int numArgsOut, MWArray m, MWArray modeling_num, MWArray 
                        imu, MWArray TR_in1)
    {
      return mcr.EvaluateFunction(numArgsOut, "Modeling", m, modeling_num, imu, TR_in1);
    }


    /// <summary>
    /// Provides the standard 5-input MWArray interface to the Modeling MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// clear all;
    /// A='a';B='a';C='a';D='a';E='a';   
    /// txt_num=input('请输入文件序号的值:');        
    /// 手动输入的地图序号,这个现在不知道在干啥，后面建模的时候好像没有用到
    /// modeling_num=input('请输入地图序号的值:');    手动输入的建模次数
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="m">Input argument #1</param>
    /// <param name="modeling_num">Input argument #2</param>
    /// <param name="imu">Input argument #3</param>
    /// <param name="TR_in1">Input argument #4</param>
    /// <param name="TT_in1">Input argument #5</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] Modeling(int numArgsOut, MWArray m, MWArray modeling_num, MWArray 
                        imu, MWArray TR_in1, MWArray TT_in1)
    {
      return mcr.EvaluateFunction(numArgsOut, "Modeling", m, modeling_num, imu, TR_in1, TT_in1);
    }


    /// <summary>
    /// Provides the standard 6-input MWArray interface to the Modeling MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// clear all;
    /// A='a';B='a';C='a';D='a';E='a';   
    /// txt_num=input('请输入文件序号的值:');        
    /// 手动输入的地图序号,这个现在不知道在干啥，后面建模的时候好像没有用到
    /// modeling_num=input('请输入地图序号的值:');    手动输入的建模次数
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="m">Input argument #1</param>
    /// <param name="modeling_num">Input argument #2</param>
    /// <param name="imu">Input argument #3</param>
    /// <param name="TR_in1">Input argument #4</param>
    /// <param name="TT_in1">Input argument #5</param>
    /// <param name="XYZ_total_in1">Input argument #6</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] Modeling(int numArgsOut, MWArray m, MWArray modeling_num, MWArray 
                        imu, MWArray TR_in1, MWArray TT_in1, MWArray XYZ_total_in1)
    {
      return mcr.EvaluateFunction(numArgsOut, "Modeling", m, modeling_num, imu, TR_in1, TT_in1, XYZ_total_in1);
    }


    /// <summary>
    /// Provides the standard 7-input MWArray interface to the Modeling MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// clear all;
    /// A='a';B='a';C='a';D='a';E='a';   
    /// txt_num=input('请输入文件序号的值:');        
    /// 手动输入的地图序号,这个现在不知道在干啥，后面建模的时候好像没有用到
    /// modeling_num=input('请输入地图序号的值:');    手动输入的建模次数
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="m">Input argument #1</param>
    /// <param name="modeling_num">Input argument #2</param>
    /// <param name="imu">Input argument #3</param>
    /// <param name="TR_in1">Input argument #4</param>
    /// <param name="TT_in1">Input argument #5</param>
    /// <param name="XYZ_total_in1">Input argument #6</param>
    /// <param name="oppupencyMap_in1">Input argument #7</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] Modeling(int numArgsOut, MWArray m, MWArray modeling_num, MWArray 
                        imu, MWArray TR_in1, MWArray TT_in1, MWArray XYZ_total_in1, 
                        MWArray oppupencyMap_in1)
    {
      return mcr.EvaluateFunction(numArgsOut, "Modeling", m, modeling_num, imu, TR_in1, TT_in1, XYZ_total_in1, oppupencyMap_in1);
    }


    /// <summary>
    /// Provides the standard 8-input MWArray interface to the Modeling MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// clear all;
    /// A='a';B='a';C='a';D='a';E='a';   
    /// txt_num=input('请输入文件序号的值:');        
    /// 手动输入的地图序号,这个现在不知道在干啥，后面建模的时候好像没有用到
    /// modeling_num=input('请输入地图序号的值:');    手动输入的建模次数
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="m">Input argument #1</param>
    /// <param name="modeling_num">Input argument #2</param>
    /// <param name="imu">Input argument #3</param>
    /// <param name="TR_in1">Input argument #4</param>
    /// <param name="TT_in1">Input argument #5</param>
    /// <param name="XYZ_total_in1">Input argument #6</param>
    /// <param name="oppupencyMap_in1">Input argument #7</param>
    /// <param name="bound_old_in1">Input argument #8</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] Modeling(int numArgsOut, MWArray m, MWArray modeling_num, MWArray 
                        imu, MWArray TR_in1, MWArray TT_in1, MWArray XYZ_total_in1, 
                        MWArray oppupencyMap_in1, MWArray bound_old_in1)
    {
      return mcr.EvaluateFunction(numArgsOut, "Modeling", m, modeling_num, imu, TR_in1, TT_in1, XYZ_total_in1, oppupencyMap_in1, bound_old_in1);
    }


    /// <summary>
    /// Provides an interface for the Modeling function in which the input and output
    /// arguments are specified as an array of MWArrays.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// M-Documentation:
    /// clear all;
    /// A='a';B='a';C='a';D='a';E='a';   
    /// txt_num=input('请输入文件序号的值:');        
    /// 手动输入的地图序号,这个现在不知道在干啥，后面建模的时候好像没有用到
    /// modeling_num=input('请输入地图序号的值:');    手动输入的建模次数
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of MWArray output arguments</param>
    /// <param name= "argsIn">Array of MWArray input arguments</param>
    ///
    public void Modeling(int numArgsOut, ref MWArray[] argsOut, MWArray[] argsIn)
    {
      mcr.EvaluateFunction("Modeling", numArgsOut, ref argsOut, argsIn);
    }



    /// <summary>
    /// This method will cause a MATLAB figure window to behave as a modal dialog box.
    /// The method will not return until all the figure windows associated with this
    /// component have been closed.
    /// </summary>
    /// <remarks>
    /// An application should only call this method when required to keep the
    /// MATLAB figure window from disappearing.  Other techniques, such as calling
    /// Console.ReadLine() from the application should be considered where
    /// possible.</remarks>
    ///
    public void WaitForFiguresToDie()
    {
      mcr.WaitForFiguresToDie();
    }



    #endregion Methods

    #region Class Members

    private static MWMCR mcr= null;

    private static Exception ex_= null;

    private bool disposed= false;

    #endregion Class Members
  }
}
