// [----------------------------------------------------------------------------------------------------------------------------------------------]
// This Quaternion class has been re-written in C# from SlimDX's C++ code.
// Without SlimDX I'd be stuck infront of mathhelp and mathworks asking myself why it was a good idea to start this project in the first place.
// So big thanks to SlimDX's Group <3
// [----------------------------------------------------------------------------------------------------------------------------------------------]
/*
 * Copyright (C) 2007-2010 SlimDX Group
 *
 * Permission is hereby granted, free  of charge, to any person obtaining a copy of this software  and
 * associated  documentation  files (the  "Software"), to deal  in the Software  without  restriction,
 * including  without  limitation  the  rights  to use,  copy,  modify,  merge,  publish,  distribute,
 * sublicense, and/or sell  copies of the  Software,  and to permit  persons to whom  the Software  is
 * furnished to do so, subject to the following conditions:
 *
 * The  above  copyright  notice  and this  permission  notice shall  be included  in  all  copies  or
 * substantial portions of the Software.
 *
 * THE SOFTWARE IS PROVIDED "AS IS",  WITHOUT WARRANTY OF  ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT
 * NOT  LIMITED  TO  THE  WARRANTIES  OF  MERCHANTABILITY,  FITNESS  FOR  A   PARTICULAR  PURPOSE  AND
 * NONINFRINGEMENT.  IN  NO  EVENT SHALL THE  AUTHORS  OR COPYRIGHT HOLDERS  BE LIABLE FOR  ANY CLAIM,
 * DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,  OUT
 * OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
 */
using Maths = System.Math;

namespace NFSScript.Math
{
    /// <summary>
    /// Quaternions are used to represent rotations.
    /// </summary>
    public struct Quaternion
    {
        /// <summary>
        /// Returns a <see cref="Quaternion"/> representing no rotation.
        /// </summary>
        public static Quaternion Identity
        {
            get
            {
                return new Quaternion(0, 0, 0, 1);
            }
        }

        /// <summary>
        /// W component of the <see cref="Quaternion"/>.
        /// </summary>
        public float w { get; private set; }

        /// <summary>
        /// X component of the <see cref="Quaternion"/>.
        /// </summary>
        public float x { get; private set; }

        /// <summary>
        /// Y component of the <see cref="Quaternion"/>.
        /// </summary>
        public float y { get; private set; }

        /// <summary>
        /// Z component of the <see cref="Quaternion"/>.
        /// </summary>
        public float z { get; private set; }

        /// <summary>
        /// Returns the length of this <see cref="Quaternion"/>.
        /// </summary>
        public float magnitude
        {
            get
            {
                return (float)Maths.Sqrt((x * x) + (y * y) + (z * z) + (w * w));
            }
        }

        /// <summary>
        /// Returns the squared length of this <see cref="Quaternion"/>.
        /// </summary>
        public float magnitudeSquared
        {
            get
            {
                return ((x * x) + (y * y) + (z * z) + (w * w));
            }
        }

        /// <summary>
        /// Axis of this <see cref="Quaternion"/>.
        /// </summary>
        public Vector3 Axis
        {
            get
            {
                float x, y, z;
                if (magnitude != 0.0f)
                {
                    float inverseLength = 1.0f / magnitude;
                    x = this.x * inverseLength;
                    y = this.y * inverseLength;
                    z = this.z * inverseLength;
                }
                else
                {
                    x = 1.0f;
                    y = 0.0f;
                    z = 0.0f;
                }

                return new Vector3(x, y, z);                
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Quaternion"/> class with the specified x,y,z,w components.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="z"></param>
        /// <param name="w"></param>
        public Quaternion(float x, float y, float z, float w)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Quaternion"/> class using components specified by an Vector3 value.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="w"></param>
        public Quaternion(Vector3 value, float w)
        {
            x = value.x;
            y = value.y;
            z = value.z;
            this.w = w;
        }

        /// <summary>
        /// Set the XYZW values of this <see cref="Quaternion"/>.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="z"></param>
        /// <param name="w"></param>
        public void Set(float x, float y, float z, float w)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }

        /// <summary>
        /// Returns a quaternion with the same rotation as the specified <see cref="Quaternion"/>, but with a length of one.
        /// </summary>
        /// <param name="quat"></param>
        /// <returns></returns>
        public static Quaternion Normalize(Quaternion quat)
        {
            float length = 1.0f / quat.magnitude;
            float x = quat.x * length;
            float y = quat.y * length;
            float z = quat.z * length;
            float w = quat.w * length;

            return new Quaternion(x, y, z, w);
        }

        /// <summary>
        /// Dot product between two rotations.
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static float Dot(Quaternion left, Quaternion right)
        {
            return (left.x * right.x) + (left.y * right.y) + (left.z * right.z) + (left.w * right.w);
        }

        /// <summary>
        /// Returns the angle between a and b.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static float AngleBetween(Quaternion a, Quaternion b)
        {
            float dot = Dot(a, b);
            return (float)((Maths.Acos(Maths.Min(Maths.Abs(dot), 1.0f)) * 2.0 * (180.0f / Mathf.PI)));
        }

        /// <summary>
        /// Interpolates between a and b by a factor and normalizes the result afterwards.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="factor"></param>
        /// <returns></returns>
        public static Quaternion Lerp(Quaternion a, Quaternion b, float factor)
        {
            float x, y, z, w;

            float inverse = 1.0f - factor;
            float dot = Dot(a, b);

            if (dot >= 0.0f)
            {
                x = (inverse * a.x) + (factor * b.x);
                y = (inverse * a.y) + (factor * b.y);
                z = (inverse * a.z) + (factor * b.z);
                w = (inverse * a.w) + (factor * b.w);
            }
            else
            {
                x = (inverse * a.x) - (factor * b.x);
                y = (inverse * a.y) - (factor * b.y);
                z = (inverse * a.z) - (factor * b.z);
                w = (inverse * a.w) - (factor * b.w);
            }

            float inverseLength = 1.0f / new Quaternion(x, y, z, w).magnitude;

            x *= inverseLength;
            y *= inverseLength;
            z *= inverseLength;
            w *= inverseLength;

            return new Quaternion(x, y, z, w);
        }

        /// <summary>
        /// Spherically interpolates between a and b by a factor.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="factor"></param>
        /// <returns></returns>
        public static Quaternion Slerp(Quaternion a, Quaternion b, float factor)
        {
            float x, y, z, w;
            float opposite, inverse;
            float dot = Dot(a, b);

            if (Maths.Abs(dot) > (1.0 - Mathf.Epsilon))
            {
                inverse = 1.0f - factor;
                opposite = factor * Maths.Sign(dot);
            }
            else
            {
                float acos = (float)Maths.Acos(Maths.Abs(dot));
                float inverseSin = (float)(1.0 / Maths.Sin(acos));

                inverse = (float)(Maths.Sin((1.0f - factor) * acos) * inverseSin);
                opposite = (float)(Maths.Sin(factor * acos) * inverseSin * Maths.Sign(dot));
            }

            x = (inverse * a.x) + (opposite * b.x);
            y = (inverse * a.y) + (opposite * b.y);
            z = (inverse * a.z) + (opposite * b.z);
            w = (inverse * a.w) + (opposite * b.w);

            return new Quaternion(x, y, z, w);
        }

        /// <summary>
        /// Spherically interpolates between a and b by factor. The parameter factor is not clamped.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="factor"></param>
        /// <returns></returns>
        public static Quaternion SlerpUnclamped(Quaternion a, Quaternion b, float factor)
        {
            if (a.magnitudeSquared == 0.0f)
            {
                if (b.magnitudeSquared == 0.0f)
                {
                    return Identity;
                }
                return b;
            }
            else if (b.magnitudeSquared == 0.0)
            {
                return a;
            }

            float invX, invY, invZ, invW;

            float cosHalfAngle = a.w * b.w + Vector3.Dot(a.Axis, b.Axis);
            if (cosHalfAngle >= 1.0f || cosHalfAngle <= -1.0f)
                return a;
            else if (cosHalfAngle < 0.0f)
            {
                invX = -b.x;
                invY = -b.y;
                invZ = -b.z;
                invW = -b.w;

                cosHalfAngle = -cosHalfAngle;
            }

            float blendA, blendB;

            if (cosHalfAngle < 0.99f)
            {
                float halfAngle = (float)Maths.Acos(cosHalfAngle);
                float sinHalfAngle = (float)Maths.Sin(halfAngle);
                float oneOverSinHalfAngle = 1.0f / sinHalfAngle;
                blendA = (float)Maths.Sin(halfAngle * (1.0f - factor)) * oneOverSinHalfAngle;
                blendB = (float)Maths.Sin(halfAngle * factor) * oneOverSinHalfAngle;
            }
            else
            {
                blendA = 1.0f - factor;
                blendB = factor;
            }

            Quaternion result = new Quaternion(blendA * a.Axis + blendB, blendA * a.w + blendB + b.w);

            if (result.magnitudeSquared > 0.0f)
                return Normalize(result);
            else return Identity;
        }

        /// <summary>
        /// Returns the Inverse of rotation.
        /// </summary>
        /// <param name="quat"></param>
        /// <returns></returns>
        public static Quaternion Inverse(Quaternion quat)
        {
            float x, y, z, w;
            float lengthSqr = quat.magnitudeSquared;

            x = -quat.x * lengthSqr;
            y = -quat.y * lengthSqr;
            z = -quat.z * lengthSqr;
            w = -quat.w * lengthSqr;

            return new Quaternion(x, y, z, w);
        }

        /// <summary>
        /// Rotates a rotation from towards to.
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <param name="maxDegressDelta"></param>
        /// <returns></returns>
        public static Quaternion RotateTowards(Quaternion from, Quaternion to, float maxDegressDelta)
        {
            float angle = AngleBetween(from, to);
            if (angle == 0.0F)
                return to;

            float t = Maths.Min(1.0f, maxDegressDelta / angle);
            return SlerpUnclamped(from, to, t);
        }

        /// <summary>
        /// Returns a quaternion with a specified yaw, pitch, and roll.
        /// </summary>
        /// <param name="yaw"></param>
        /// <param name="pitch"></param>
        /// <param name="roll"></param>
        /// <returns></returns>
        public static Quaternion RotationYawPitchRoll(float yaw, float pitch, float roll)
        {
            float halfRoll = roll * 0.5f;
            float sinRoll = (float)Maths.Sin(halfRoll);
            float cosRoll = (float)Maths.Cos(halfRoll);
            float halfPitch = pitch * 0.5f;
            float sinPitch = (float)Maths.Sin(halfPitch);
            float cosPitch = (float)Maths.Cos(halfPitch);
            float halfYaw = yaw * 0.5f;
            float sinYaw = (float)Maths.Sin(halfYaw);
            float cosYaw = (float)Maths.Cos(halfYaw);

            float x = (cosYaw * sinPitch * cosRoll) + (sinYaw * cosPitch * sinRoll);
            float y = (sinYaw * cosPitch * cosRoll) - (cosYaw * sinPitch * sinRoll);
            float z = (cosYaw * cosPitch * sinRoll) - (sinYaw * sinPitch * cosRoll);
            float w = (cosYaw * cosPitch * cosRoll) + (sinYaw * sinPitch * sinRoll);

            return new Quaternion(x, y, z, w);
        }

        /// <summary>
        /// Returns a rotation that rotates z degrees around the z axis, x degrees around the x axis, and y degrees around the y axis.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="z"></param>
        /// <returns></returns>
        public static Quaternion Euler(float x, float y, float z)
        {
            return RotationYawPitchRoll(x * Mathf.Deg2Rad, y * Mathf.Deg2Rad, z * Mathf.Deg2Rad);
        }

        /// <summary>
        /// Returns a rotation that rotates z degrees around the z axis, x degrees around the x axis, and y degrees around the y axis.
        /// </summary>
        /// <param name="euler"></param>
        /// <returns></returns>
        public static Quaternion Euler(Vector3 euler)
        {
            Vector3 eulerRad = euler * Mathf.Deg2Rad;
            return RotationYawPitchRoll(eulerRad.x, eulerRad.y, eulerRad.z);
        }

        /// <summary>
        /// Creates a rotation which rotates from fromDirection to toDirection.
        /// </summary>
        /// <param name="fromDir"></param>
        /// <param name="toDir"></param>
        /// <returns></returns>
        public static Quaternion FromToRotation(Vector3 fromDir, Vector3 toDir)
        {
            float normAB = (float)Maths.Sqrt(fromDir.magnitudeSquared * fromDir.magnitudeSquared);
            float w = normAB + Vector3.Dot(fromDir, toDir);

            Quaternion result;
            if (w >= 1e-6f * normAB)
                result = new Quaternion(Vector3.Cross(fromDir, toDir), w);
            else
            {
                w = 0.0f;
                result = (Maths.Abs(fromDir.x) > Maths.Abs(fromDir.y) ? new Quaternion(-fromDir.z, 0.0f, fromDir.x, w) : new Quaternion(0.0f, -fromDir.z, fromDir.y, w));
            }

            return Normalize(result);
        }
    }
}
