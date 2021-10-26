using System;
using System.Collections.Generic;
using System.Windows.Forms;

//2
using System.Drawing;

namespace OpenGL
{
    class cOGL
    {
        Control p;
        int Width;
        int Height;

        public cOGL(Control pb)
        {
            p=pb;
            Width = p.Width;
            Height = p.Height; 
            InitializeGL();
        }

        ~cOGL()
        {
            WGL.wglDeleteContext(m_uint_RC);
        }

		uint m_uint_HWND = 0;
        public uint HWND
		{
			get{ return m_uint_HWND; }
		}
		
        uint m_uint_DC   = 0;

        public uint DC
		{
			get{ return m_uint_DC;}
		}
		uint m_uint_RC   = 0;

        public uint RC
		{
			get{ return m_uint_RC; }
		}

        protected void DrawAll()
        {
            
            // cube
            GL.glBegin(GL.GL_QUADS);


            //1

            GL.glColor3f(0.0f, 0.0f, 0.0f);
            GL.glVertex3f(0.0f, 0.0f, 1.5f);

            GL.glColor3f(0.0f, 1.0f, 0.0f);
            GL.glVertex3f(0.0f, 1.0f, 1.5f);

            GL.glColor3f(1.0f, 1.0f, 0.0f);
            GL.glVertex3f(1.0f, 1.0f, 1.5f);

            GL.glColor3f(1.0f, 0.0f, 0.0f);
            GL.glVertex3f(1.0f, 0.0f, 1.5f);

            GL.glEnd();


            //2

            GL.glColor3f(1.0f, 1.0f, 1.0f);
            GL.glEnable(GL.GL_TEXTURE_2D);
            InitTexture("nun.BMP");
            GL.glBindTexture(GL.GL_TEXTURE_2D, texture[0]);
            GL.glDisable(GL.GL_LIGHTING);


            GL.glBegin(GL.GL_QUADS);

            GL.glTexCoord2f(1.0f, 0.0f);
            GL.glVertex3f(0.0f, 0.0f, 0.5f);

            GL.glTexCoord2f(1.0f, 1.0f);
            GL.glVertex3f(0.0f, 0.0f, 1.5f);

            GL.glTexCoord2f(0.0f, 1.0f);
            GL.glVertex3f(0.0f, 1.0f, 1.5f);

            GL.glTexCoord2f(0.0f, 0.0f);
            GL.glVertex3f(0.0f, 1.0f, 0.5f);

            GL.glEnd();

            GL.glDisable(GL.GL_TEXTURE_2D);

            //3
            
            GL.glColor3f(1.0f, 0.0f, 0.0f);
            GL.glEnable(GL.GL_TEXTURE_2D);
            InitTexture("pei.BMP");
            GL.glBindTexture(GL.GL_TEXTURE_2D, texture[0]);
            GL.glDisable(GL.GL_LIGHTING);


            GL.glBegin(GL.GL_QUADS);

            GL.glTexCoord2f(0.0f, 0.0f);
            GL.glVertex3f(0.0f, 0.0f, 0.5f);

            GL.glTexCoord2f(1.0f, 0.0f);
            GL.glVertex3f(1.0f, 0.0f, 0.5f);

            GL.glTexCoord2f(1.0f, 1.0f);
            GL.glVertex3f(1.0f, 0.0f, 1.5f);

            GL.glTexCoord2f(0.0f, 1.0f);
            GL.glVertex3f(0.0f, 0.0f, 1.5f);


            GL.glEnd();

            GL.glDisable(GL.GL_TEXTURE_2D);


            //4

            GL.glColor3f(0.0f, 1.0f, 0.0f);
            GL.glEnable(GL.GL_TEXTURE_2D);
            InitTexture("hai.BMP");
            GL.glBindTexture(GL.GL_TEXTURE_2D, texture[0]);
            GL.glDisable(GL.GL_LIGHTING);

            GL.glBegin(GL.GL_QUADS);

            GL.glTexCoord2f(0.0f, 0.0f);
            GL.glVertex3f(1.0f, 0.0f, 0.5f);

            GL.glTexCoord2f(0.0f, 1.0f);
            GL.glVertex3f(1.0f, 0.0f, 1.5f);

            GL.glTexCoord2f(1.0f, 1.0f);
            GL.glVertex3f(1.0f, 1.0f, 1.5f);

            GL.glTexCoord2f(1.0f, 0.0f);
            GL.glVertex3f(1.0f, 1.0f, 0.5f);

            GL.glEnd();

            //5

            GL.glColor3f(0.0f, 0.0f, 1.0f);
            GL.glEnable(GL.GL_TEXTURE_2D);
            InitTexture("gimel.BMP");
            GL.glBindTexture(GL.GL_TEXTURE_2D, texture[0]);
            GL.glDisable(GL.GL_LIGHTING);

            GL.glBegin(GL.GL_QUADS);

            GL.glTexCoord2f(0.0f, 1.0f);
            GL.glVertex3f(1.0f, 1.0f, 1.5f);

            GL.glTexCoord2f(0.0f, 0.0f);
            GL.glVertex3f(1.0f, 1.0f, 0.5f);

            GL.glTexCoord2f(1.0f, 0.0f);
            GL.glVertex3f(0.0f, 1.0f, 0.5f);

            GL.glTexCoord2f(1.0f, 1.0f);
            GL.glVertex3f(0.0f, 1.0f, 1.5f);

            GL.glEnd();

           
            GL.glBegin(GL.GL_TRIANGLES);
            
            //1//

            GL.glColor3f(1.0f, 1.0f, 1.0f);
            GL.glVertex3f(1.0f, 1.0f, 0.5f);

            GL.glColor3f(0.0f, 1.0f, 1.0f);
            GL.glVertex3f(0.0f, 1.0f, 0.5f);

            GL.glColor3f(1.0f, 1.0f, 1.0f);
            GL.glVertex3f(0.5f, 0.5f, 0.0f);

            //2//

            GL.glColor3f(0.0f, 1.0f, 1.0f);
            GL.glVertex3f(0.0f, 1.0f, 0.5f);

            GL.glColor3f(0.0f, 0.0f, 1.0f);
            GL.glVertex3f(0.0f, 0.0f, 0.5f);

            GL.glColor3f(1.0f, 1.0f, 1.0f);
            GL.glVertex3f(0.5f, 0.5f, 0.0f);

            //3//

            GL.glColor3f(0.0f, 0.0f, 1.0f);
            GL.glVertex3f(0.0f, 0.0f, 0.5f);

            GL.glColor3f(1.0f, 0.0f, 1.0f);
            GL.glVertex3f(1.0f, 0.0f, 0.5f);

            GL.glColor3f(1.0f, 1.0f, 1.0f);
            GL.glVertex3f(0.5f, 0.5f, 0.0f);

            //4//

            GL.glColor3f(1.0f, 1.0f, 1.0f);
            GL.glVertex3f(1.0f, 1.0f, 0.5f);

            GL.glColor3f(1.0f, 0.0f, 1.0f);
            GL.glVertex3f(1.0f, 0.0f, 0.5f);

            GL.glColor3f(1.0f, 1.0f, 1.0f);
            GL.glVertex3f(0.5f, 0.5f, 0.0f);

            GL.glEnd();

        }


        float angle = 0.0f;
        float falling_angle = 0.0f;
        public void Draw()
        {
            if (m_uint_DC == 0 || m_uint_RC == 0)
                return;

            GL.glClear(GL.GL_COLOR_BUFFER_BIT | GL.GL_DEPTH_BUFFER_BIT);
            GL.glLoadIdentity();

            
            GL.glTranslatef(-0.3f, -0.6f, -6.0f);					// Translate 6 Units Into The Screen
            GL.glRotatef(-90, 1.0f, 0.0f, 0.0f);

            GL.glTranslatef(0.5f, 0.5f, 0.0f);
            GL.glRotatef(-90, 0.0f, 0.0f, 1.0f);
            GL.glTranslatef(-0.5f, -0.5f, 0.0f);

            //axes
            GL.glBegin(GL.GL_LINES);
            //x  RED
            GL.glColor3f(1.0f, 0.0f, 0.0f);
            GL.glVertex3f(0.0f, 0.0f, 0.0f);
            GL.glVertex3f(3.0f, 0.0f, 0.0f);
            //y  GREEN 
            GL.glColor3f(0.0f, 1.0f, 0.0f);
            GL.glVertex3f(0.0f, 0.0f, 0.0f);
            GL.glVertex3f(0.0f, 3.0f, 0.0f);
            //z  BLUE
            GL.glColor3f(0.0f, 0.0f, 1.0f);
            GL.glVertex3f(0.0f, 0.0f, 0.0f);
            GL.glVertex3f(0.0f, 0.0f, 3.0f);

            GL.glEnd();

            GL.glTranslatef(0.5f, 0.5f, 0.0f);

            if (45 >= falling_angle)
            {

                angle += 5.0f;
                
                if (angle > 1800)
                    falling_angle += 0.125f;
            }
          
            GL.glRotatef(angle, 0.0f, 0.0f, 1.0f);
            GL.glRotatef(falling_angle, 1.0f, 0.0f, 0.0f);
            GL.glTranslatef(-0.5f, -0.5f, 0.0f);
           
            DrawAll();

            GL.glTranslatef(0.5f, 0.5f, 1.5f);

            GLUquadric obj;
            obj = GLU.gluNewQuadric(); //do not forget to call gluDeleteQuadric at the end

            GL.glColor3f(0.1f, 0.1f, 1.0f);
            GLU.gluCylinder(obj, 0.1, 0.1, 1, 16, 16);

            GLU.gluDeleteQuadric(obj); //the MUST in case of previous call to gluNewQuadric

            GL.glTranslatef(-0.5f, -0.5f, -1.5f);

            GL.glFlush();

            WGL.wglSwapBuffers(m_uint_DC);

        }

        protected virtual void InitializeGL()
        {
            m_uint_HWND = (uint)p.Handle.ToInt32();
            m_uint_DC = WGL.GetDC(m_uint_HWND);

            // Not doing the following WGL.wglSwapBuffers() on the DC will
            // result in a failure to subsequently create the RC.
            WGL.wglSwapBuffers(m_uint_DC);

            WGL.PIXELFORMATDESCRIPTOR pfd = new WGL.PIXELFORMATDESCRIPTOR();
            WGL.ZeroPixelDescriptor(ref pfd);
            pfd.nVersion = 1;
            pfd.dwFlags = (WGL.PFD_DRAW_TO_WINDOW | WGL.PFD_SUPPORT_OPENGL | WGL.PFD_DOUBLEBUFFER);
            pfd.iPixelType = (byte)(WGL.PFD_TYPE_RGBA);
            pfd.cColorBits = 32;
            pfd.cDepthBits = 32;
            pfd.iLayerType = (byte)(WGL.PFD_MAIN_PLANE);

            int pixelFormatIndex = 0;
            pixelFormatIndex = WGL.ChoosePixelFormat(m_uint_DC, ref pfd);
            if (pixelFormatIndex == 0)
            {
                MessageBox.Show("Unable to retrieve pixel format");
                return;
            }

            if (WGL.SetPixelFormat(m_uint_DC, pixelFormatIndex, ref pfd) == 0)
            {
                MessageBox.Show("Unable to set pixel format");
                return;
            }
            //Create rendering context
            m_uint_RC = WGL.wglCreateContext(m_uint_DC);
            if (m_uint_RC == 0)
            {
                MessageBox.Show("Unable to get rendering context");
                return;
            }
            if (WGL.wglMakeCurrent(m_uint_DC, m_uint_RC) == 0)
            {
                MessageBox.Show("Unable to make rendering context current");
                return;
            }


            initRenderingGL();
        }

        public void OnResize()
        {
            Width = p.Width;
            Height = p.Height;

            //!!!!!!!
            GL.glViewport(0, 0, Width, Height);
            //!!!!!!!

            initRenderingGL();
            Draw();
        }

        protected virtual void initRenderingGL()
        {
            if (m_uint_DC == 0 || m_uint_RC == 0)
                return;
            if (this.Width == 0 || this.Height == 0)
                return;
            GL.glEnable(GL.GL_DEPTH_TEST);
            GL.glDepthFunc(GL.GL_LEQUAL);

            GL.glViewport(0, 0, this.Width, this.Height);
            GL.glClearColor(0, 0, 0, 0);
            GL.glMatrixMode(GL.GL_PROJECTION);
            GL.glLoadIdentity();
            GLU.gluPerspective(45.0, ((double)Width) / Height, 1.0, 1000.0);
            GL.glMatrixMode(GL.GL_MODELVIEW);
            GL.glLoadIdentity();

            //InitTexture("image.bmp");
        }

        public uint[] texture;		// texture

        void InitTexture(string imageBMPfile)
        {
            GL.glEnable(GL.GL_TEXTURE_2D);

            texture = new uint[1];		// storage for texture

            Bitmap image = new Bitmap(imageBMPfile);
            image.RotateFlip(RotateFlipType.RotateNoneFlipY); //Y axis in Windows is directed downwards, while in OpenGL-upwards
            System.Drawing.Imaging.BitmapData bitmapdata;
            Rectangle rect = new Rectangle(0, 0, image.Width, image.Height);

            bitmapdata = image.LockBits(rect, System.Drawing.Imaging.ImageLockMode.ReadOnly,
                System.Drawing.Imaging.PixelFormat.Format24bppRgb);

            GL.glGenTextures(1, texture);
            GL.glBindTexture(GL.GL_TEXTURE_2D, texture[0]);
            //  VN-in order to use System.Drawing.Imaging.BitmapData Scan0 I've added overloaded version to
            //  OpenGL.cs
            //  [DllImport(GL_DLL, EntryPoint = "glTexImage2D")]
            //  public static extern void glTexImage2D(uint target, int level, int internalformat, int width, int height, int border, uint format, uint type, IntPtr pixels);
            GL.glTexImage2D(GL.GL_TEXTURE_2D, 0, (int)GL.GL_RGB8, image.Width, image.Height,
                0, GL.GL_BGR_EXT, GL.GL_UNSIGNED_byte, bitmapdata.Scan0);

            GL.glTexParameteri(GL.GL_TEXTURE_2D, GL.GL_TEXTURE_MIN_FILTER, (int)GL.GL_LINEAR);		// Linear Filtering
            GL.glTexParameteri(GL.GL_TEXTURE_2D, GL.GL_TEXTURE_MAG_FILTER, (int)GL.GL_LINEAR);		// Linear Filtering

            image.UnlockBits(bitmapdata);
            image.Dispose();
        }

    }
}
