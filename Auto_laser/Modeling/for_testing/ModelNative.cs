/*
* MATLAB Compiler: 6.5 (R2017b)
* Date: Thu Dec 19 13:02:22 2019
* Arguments:
* "-B""macro_default""-W""dotnet:Modeling,Model,4.0,private""-T""link:lib""-d""F:\old_lase
* r_change\Auto_laser\Modeling\for_testing""-v""class{Model:F:\old_laser_change\����ʵ��\M
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

namespace ModelingNative
{

  /// <summary>
  /// The Model class provides a CLS compliant, Object (native) interface to the MATLAB
  /// functions contained in the files:
  /// <newpara></newpara>
  /// F:\old_laser_change\����ʵ��\Modeling.m
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
    /// Provides a single output, 0-input Objectinterface to the Modeling MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// clear all;
    /// A='a';B='a';C='a';D='a';E='a';   
    /// txt_num=input('�������ļ���ŵ�ֵ:');        
    /// �ֶ�����ĵ�ͼ���,������ڲ�֪���ڸ�ɶ�����潨ģ��ʱ�����û���õ�
    /// modeling_num=input('�������ͼ��ŵ�ֵ:');    �ֶ�����Ľ�ģ����
    /// </remarks>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object Modeling()
    {
      return mcr.EvaluateFunction("Modeling", new Object[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input Objectinterface to the Modeling MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// clear all;
    /// A='a';B='a';C='a';D='a';E='a';   
    /// txt_num=input('�������ļ���ŵ�ֵ:');        
    /// �ֶ�����ĵ�ͼ���,������ڲ�֪���ڸ�ɶ�����潨ģ��ʱ�����û���õ�
    /// modeling_num=input('�������ͼ��ŵ�ֵ:');    �ֶ�����Ľ�ģ����
    /// </remarks>
    /// <param name="m">Input argument #1</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object Modeling(Object m)
    {
      return mcr.EvaluateFunction("Modeling", m);
    }


    /// <summary>
    /// Provides a single output, 2-input Objectinterface to the Modeling MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// clear all;
    /// A='a';B='a';C='a';D='a';E='a';   
    /// txt_num=input('�������ļ���ŵ�ֵ:');        
    /// �ֶ�����ĵ�ͼ���,������ڲ�֪���ڸ�ɶ�����潨ģ��ʱ�����û���õ�
    /// modeling_num=input('�������ͼ��ŵ�ֵ:');    �ֶ�����Ľ�ģ����
    /// </remarks>
    /// <param name="m">Input argument #1</param>
    /// <param name="modeling_num">Input argument #2</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object Modeling(Object m, Object modeling_num)
    {
      return mcr.EvaluateFunction("Modeling", m, modeling_num);
    }


    /// <summary>
    /// Provides a single output, 3-input Objectinterface to the Modeling MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// clear all;
    /// A='a';B='a';C='a';D='a';E='a';   
    /// txt_num=input('�������ļ���ŵ�ֵ:');        
    /// �ֶ�����ĵ�ͼ���,������ڲ�֪���ڸ�ɶ�����潨ģ��ʱ�����û���õ�
    /// modeling_num=input('�������ͼ��ŵ�ֵ:');    �ֶ�����Ľ�ģ����
    /// </remarks>
    /// <param name="m">Input argument #1</param>
    /// <param name="modeling_num">Input argument #2</param>
    /// <param name="imu">Input argument #3</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object Modeling(Object m, Object modeling_num, Object imu)
    {
      return mcr.EvaluateFunction("Modeling", m, modeling_num, imu);
    }


    /// <summary>
    /// Provides a single output, 4-input Objectinterface to the Modeling MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// clear all;
    /// A='a';B='a';C='a';D='a';E='a';   
    /// txt_num=input('�������ļ���ŵ�ֵ:');        
    /// �ֶ�����ĵ�ͼ���,������ڲ�֪���ڸ�ɶ�����潨ģ��ʱ�����û���õ�
    /// modeling_num=input('�������ͼ��ŵ�ֵ:');    �ֶ�����Ľ�ģ����
    /// </remarks>
    /// <param name="m">Input argument #1</param>
    /// <param name="modeling_num">Input argument #2</param>
    /// <param name="imu">Input argument #3</param>
    /// <param name="TR_in1">Input argument #4</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object Modeling(Object m, Object modeling_num, Object imu, Object TR_in1)
    {
      return mcr.EvaluateFunction("Modeling", m, modeling_num, imu, TR_in1);
    }


    /// <summary>
    /// Provides a single output, 5-input Objectinterface to the Modeling MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// clear all;
    /// A='a';B='a';C='a';D='a';E='a';   
    /// txt_num=input('�������ļ���ŵ�ֵ:');        
    /// �ֶ�����ĵ�ͼ���,������ڲ�֪���ڸ�ɶ�����潨ģ��ʱ�����û���õ�
    /// modeling_num=input('�������ͼ��ŵ�ֵ:');    �ֶ�����Ľ�ģ����
    /// </remarks>
    /// <param name="m">Input argument #1</param>
    /// <param name="modeling_num">Input argument #2</param>
    /// <param name="imu">Input argument #3</param>
    /// <param name="TR_in1">Input argument #4</param>
    /// <param name="TT_in1">Input argument #5</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object Modeling(Object m, Object modeling_num, Object imu, Object TR_in1, 
                     Object TT_in1)
    {
      return mcr.EvaluateFunction("Modeling", m, modeling_num, imu, TR_in1, TT_in1);
    }


    /// <summary>
    /// Provides a single output, 6-input Objectinterface to the Modeling MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// clear all;
    /// A='a';B='a';C='a';D='a';E='a';   
    /// txt_num=input('�������ļ���ŵ�ֵ:');        
    /// �ֶ�����ĵ�ͼ���,������ڲ�֪���ڸ�ɶ�����潨ģ��ʱ�����û���õ�
    /// modeling_num=input('�������ͼ��ŵ�ֵ:');    �ֶ�����Ľ�ģ����
    /// </remarks>
    /// <param name="m">Input argument #1</param>
    /// <param name="modeling_num">Input argument #2</param>
    /// <param name="imu">Input argument #3</param>
    /// <param name="TR_in1">Input argument #4</param>
    /// <param name="TT_in1">Input argument #5</param>
    /// <param name="XYZ_total_in1">Input argument #6</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object Modeling(Object m, Object modeling_num, Object imu, Object TR_in1, 
                     Object TT_in1, Object XYZ_total_in1)
    {
      return mcr.EvaluateFunction("Modeling", m, modeling_num, imu, TR_in1, TT_in1, XYZ_total_in1);
    }


    /// <summary>
    /// Provides a single output, 7-input Objectinterface to the Modeling MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// clear all;
    /// A='a';B='a';C='a';D='a';E='a';   
    /// txt_num=input('�������ļ���ŵ�ֵ:');        
    /// �ֶ�����ĵ�ͼ���,������ڲ�֪���ڸ�ɶ�����潨ģ��ʱ�����û���õ�
    /// modeling_num=input('�������ͼ��ŵ�ֵ:');    �ֶ�����Ľ�ģ����
    /// </remarks>
    /// <param name="m">Input argument #1</param>
    /// <param name="modeling_num">Input argument #2</param>
    /// <param name="imu">Input argument #3</param>
    /// <param name="TR_in1">Input argument #4</param>
    /// <param name="TT_in1">Input argument #5</param>
    /// <param name="XYZ_total_in1">Input argument #6</param>
    /// <param name="oppupencyMap_in1">Input argument #7</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object Modeling(Object m, Object modeling_num, Object imu, Object TR_in1, 
                     Object TT_in1, Object XYZ_total_in1, Object oppupencyMap_in1)
    {
      return mcr.EvaluateFunction("Modeling", m, modeling_num, imu, TR_in1, TT_in1, XYZ_total_in1, oppupencyMap_in1);
    }


    /// <summary>
    /// Provides a single output, 8-input Objectinterface to the Modeling MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// clear all;
    /// A='a';B='a';C='a';D='a';E='a';   
    /// txt_num=input('�������ļ���ŵ�ֵ:');        
    /// �ֶ�����ĵ�ͼ���,������ڲ�֪���ڸ�ɶ�����潨ģ��ʱ�����û���õ�
    /// modeling_num=input('�������ͼ��ŵ�ֵ:');    �ֶ�����Ľ�ģ����
    /// </remarks>
    /// <param name="m">Input argument #1</param>
    /// <param name="modeling_num">Input argument #2</param>
    /// <param name="imu">Input argument #3</param>
    /// <param name="TR_in1">Input argument #4</param>
    /// <param name="TT_in1">Input argument #5</param>
    /// <param name="XYZ_total_in1">Input argument #6</param>
    /// <param name="oppupencyMap_in1">Input argument #7</param>
    /// <param name="bound_old_in1">Input argument #8</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object Modeling(Object m, Object modeling_num, Object imu, Object TR_in1, 
                     Object TT_in1, Object XYZ_total_in1, Object oppupencyMap_in1, Object 
                     bound_old_in1)
    {
      return mcr.EvaluateFunction("Modeling", m, modeling_num, imu, TR_in1, TT_in1, XYZ_total_in1, oppupencyMap_in1, bound_old_in1);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the Modeling MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// clear all;
    /// A='a';B='a';C='a';D='a';E='a';   
    /// txt_num=input('�������ļ���ŵ�ֵ:');        
    /// �ֶ�����ĵ�ͼ���,������ڲ�֪���ڸ�ɶ�����潨ģ��ʱ�����û���õ�
    /// modeling_num=input('�������ͼ��ŵ�ֵ:');    �ֶ�����Ľ�ģ����
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] Modeling(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "Modeling", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the Modeling MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// clear all;
    /// A='a';B='a';C='a';D='a';E='a';   
    /// txt_num=input('�������ļ���ŵ�ֵ:');        
    /// �ֶ�����ĵ�ͼ���,������ڲ�֪���ڸ�ɶ�����潨ģ��ʱ�����û���õ�
    /// modeling_num=input('�������ͼ��ŵ�ֵ:');    �ֶ�����Ľ�ģ����
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="m">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] Modeling(int numArgsOut, Object m)
    {
      return mcr.EvaluateFunction(numArgsOut, "Modeling", m);
    }


    /// <summary>
    /// Provides the standard 2-input Object interface to the Modeling MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// clear all;
    /// A='a';B='a';C='a';D='a';E='a';   
    /// txt_num=input('�������ļ���ŵ�ֵ:');        
    /// �ֶ�����ĵ�ͼ���,������ڲ�֪���ڸ�ɶ�����潨ģ��ʱ�����û���õ�
    /// modeling_num=input('�������ͼ��ŵ�ֵ:');    �ֶ�����Ľ�ģ����
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="m">Input argument #1</param>
    /// <param name="modeling_num">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] Modeling(int numArgsOut, Object m, Object modeling_num)
    {
      return mcr.EvaluateFunction(numArgsOut, "Modeling", m, modeling_num);
    }


    /// <summary>
    /// Provides the standard 3-input Object interface to the Modeling MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// clear all;
    /// A='a';B='a';C='a';D='a';E='a';   
    /// txt_num=input('�������ļ���ŵ�ֵ:');        
    /// �ֶ�����ĵ�ͼ���,������ڲ�֪���ڸ�ɶ�����潨ģ��ʱ�����û���õ�
    /// modeling_num=input('�������ͼ��ŵ�ֵ:');    �ֶ�����Ľ�ģ����
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="m">Input argument #1</param>
    /// <param name="modeling_num">Input argument #2</param>
    /// <param name="imu">Input argument #3</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] Modeling(int numArgsOut, Object m, Object modeling_num, Object imu)
    {
      return mcr.EvaluateFunction(numArgsOut, "Modeling", m, modeling_num, imu);
    }


    /// <summary>
    /// Provides the standard 4-input Object interface to the Modeling MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// clear all;
    /// A='a';B='a';C='a';D='a';E='a';   
    /// txt_num=input('�������ļ���ŵ�ֵ:');        
    /// �ֶ�����ĵ�ͼ���,������ڲ�֪���ڸ�ɶ�����潨ģ��ʱ�����û���õ�
    /// modeling_num=input('�������ͼ��ŵ�ֵ:');    �ֶ�����Ľ�ģ����
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="m">Input argument #1</param>
    /// <param name="modeling_num">Input argument #2</param>
    /// <param name="imu">Input argument #3</param>
    /// <param name="TR_in1">Input argument #4</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] Modeling(int numArgsOut, Object m, Object modeling_num, Object imu, 
                       Object TR_in1)
    {
      return mcr.EvaluateFunction(numArgsOut, "Modeling", m, modeling_num, imu, TR_in1);
    }


    /// <summary>
    /// Provides the standard 5-input Object interface to the Modeling MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// clear all;
    /// A='a';B='a';C='a';D='a';E='a';   
    /// txt_num=input('�������ļ���ŵ�ֵ:');        
    /// �ֶ�����ĵ�ͼ���,������ڲ�֪���ڸ�ɶ�����潨ģ��ʱ�����û���õ�
    /// modeling_num=input('�������ͼ��ŵ�ֵ:');    �ֶ�����Ľ�ģ����
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
    public Object[] Modeling(int numArgsOut, Object m, Object modeling_num, Object imu, 
                       Object TR_in1, Object TT_in1)
    {
      return mcr.EvaluateFunction(numArgsOut, "Modeling", m, modeling_num, imu, TR_in1, TT_in1);
    }


    /// <summary>
    /// Provides the standard 6-input Object interface to the Modeling MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// clear all;
    /// A='a';B='a';C='a';D='a';E='a';   
    /// txt_num=input('�������ļ���ŵ�ֵ:');        
    /// �ֶ�����ĵ�ͼ���,������ڲ�֪���ڸ�ɶ�����潨ģ��ʱ�����û���õ�
    /// modeling_num=input('�������ͼ��ŵ�ֵ:');    �ֶ�����Ľ�ģ����
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
    public Object[] Modeling(int numArgsOut, Object m, Object modeling_num, Object imu, 
                       Object TR_in1, Object TT_in1, Object XYZ_total_in1)
    {
      return mcr.EvaluateFunction(numArgsOut, "Modeling", m, modeling_num, imu, TR_in1, TT_in1, XYZ_total_in1);
    }


    /// <summary>
    /// Provides the standard 7-input Object interface to the Modeling MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// clear all;
    /// A='a';B='a';C='a';D='a';E='a';   
    /// txt_num=input('�������ļ���ŵ�ֵ:');        
    /// �ֶ�����ĵ�ͼ���,������ڲ�֪���ڸ�ɶ�����潨ģ��ʱ�����û���õ�
    /// modeling_num=input('�������ͼ��ŵ�ֵ:');    �ֶ�����Ľ�ģ����
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
    public Object[] Modeling(int numArgsOut, Object m, Object modeling_num, Object imu, 
                       Object TR_in1, Object TT_in1, Object XYZ_total_in1, Object 
                       oppupencyMap_in1)
    {
      return mcr.EvaluateFunction(numArgsOut, "Modeling", m, modeling_num, imu, TR_in1, TT_in1, XYZ_total_in1, oppupencyMap_in1);
    }


    /// <summary>
    /// Provides the standard 8-input Object interface to the Modeling MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// clear all;
    /// A='a';B='a';C='a';D='a';E='a';   
    /// txt_num=input('�������ļ���ŵ�ֵ:');        
    /// �ֶ�����ĵ�ͼ���,������ڲ�֪���ڸ�ɶ�����潨ģ��ʱ�����û���õ�
    /// modeling_num=input('�������ͼ��ŵ�ֵ:');    �ֶ�����Ľ�ģ����
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
    public Object[] Modeling(int numArgsOut, Object m, Object modeling_num, Object imu, 
                       Object TR_in1, Object TT_in1, Object XYZ_total_in1, Object 
                       oppupencyMap_in1, Object bound_old_in1)
    {
      return mcr.EvaluateFunction(numArgsOut, "Modeling", m, modeling_num, imu, TR_in1, TT_in1, XYZ_total_in1, oppupencyMap_in1, bound_old_in1);
    }


    /// <summary>
    /// Provides an interface for the Modeling function in which the input and output
    /// arguments are specified as an array of Objects.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// M-Documentation:
    /// clear all;
    /// A='a';B='a';C='a';D='a';E='a';   
    /// txt_num=input('�������ļ���ŵ�ֵ:');        
    /// �ֶ�����ĵ�ͼ���,������ڲ�֪���ڸ�ɶ�����潨ģ��ʱ�����û���õ�
    /// modeling_num=input('�������ͼ��ŵ�ֵ:');    �ֶ�����Ľ�ģ����
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of Object output arguments</param>
    /// <param name= "argsIn">Array of Object input arguments</param>
    /// <param name= "varArgsIn">Array of Object representing variable input
    /// arguments</param>
    ///
    [MATLABSignature("Modeling", 8, 13, 0)]
    protected void Modeling(int numArgsOut, ref Object[] argsOut, Object[] argsIn, params Object[] varArgsIn)
    {
        mcr.EvaluateFunctionForTypeSafeCall("Modeling", numArgsOut, ref argsOut, argsIn, varArgsIn);
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
