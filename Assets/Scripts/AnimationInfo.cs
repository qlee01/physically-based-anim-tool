﻿using UnityEngine;
using UnityEditor;

public static class AnimationInfo
{
    public static RootMotionCurves GetRootMotionCurves(AnimationClip clip)
    {
        EditorCurveBinding s_RootTXCurveBinding = EditorCurveBinding.FloatCurve("", typeof(Animator), "RootT.x");
        EditorCurveBinding s_RootTYCurveBinding = EditorCurveBinding.FloatCurve("", typeof(Animator), "RootT.y");
        EditorCurveBinding s_RootTZCurveBinding = EditorCurveBinding.FloatCurve("", typeof(Animator), "RootT.z");
        EditorCurveBinding s_RootQXCurveBinding = EditorCurveBinding.FloatCurve("", typeof(Animator), "RootQ.x");
        EditorCurveBinding s_RootQYCurveBinding = EditorCurveBinding.FloatCurve("", typeof(Animator), "RootQ.y");
        EditorCurveBinding s_RootQZCurveBinding = EditorCurveBinding.FloatCurve("", typeof(Animator), "RootQ.z");
        EditorCurveBinding s_RootQWCurveBinding = EditorCurveBinding.FloatCurve("", typeof(Animator), "RootQ.w");

        var curveBindings = AnimationUtility.GetCurveBindings(clip);
        foreach (var curveBinding in curveBindings)
        {
            var curve = AnimationUtility.GetEditorCurve(clip, curveBinding);
            if(curveBinding.propertyName == "RootT.x")
                Debug.Log("curve> " + curveBinding.path + ", propertyname " + curveBinding.propertyName);
        }

        RootMotionCurves r = new RootMotionCurves
        {
            rootTXCurve = AnimationUtility.GetEditorCurve(clip, s_RootTXCurveBinding),
            rootTYCurve = AnimationUtility.GetEditorCurve(clip, s_RootTYCurveBinding),
            rootTZCurve = AnimationUtility.GetEditorCurve(clip, s_RootTZCurveBinding),
            rootQXCurve = AnimationUtility.GetEditorCurve(clip, s_RootQXCurveBinding),
            rootQYCurve = AnimationUtility.GetEditorCurve(clip, s_RootQYCurveBinding),
            rootQZCurve = AnimationUtility.GetEditorCurve(clip, s_RootQZCurveBinding),
            rootQWCurve = AnimationUtility.GetEditorCurve(clip, s_RootQWCurveBinding)
        };

        return r;
    }

    public static void WriteRootMotionCurves(AnimationClip clip, RootMotionCurves rootMotionCurves)
    {

        EditorCurveBinding s_RootTXCurveBinding = EditorCurveBinding.FloatCurve("", typeof(Animator), "RootT.x");
        EditorCurveBinding s_RootTYCurveBinding = EditorCurveBinding.FloatCurve("", typeof(Animator), "RootT.y");
        EditorCurveBinding s_RootTZCurveBinding = EditorCurveBinding.FloatCurve("", typeof(Animator), "RootT.z");
        EditorCurveBinding s_RootQXCurveBinding = EditorCurveBinding.FloatCurve("", typeof(Animator), "RootQ.x");
        EditorCurveBinding s_RootQYCurveBinding = EditorCurveBinding.FloatCurve("", typeof(Animator), "RootQ.y");
        EditorCurveBinding s_RootQZCurveBinding = EditorCurveBinding.FloatCurve("", typeof(Animator), "RootQ.z");
        EditorCurveBinding s_RootQWCurveBinding = EditorCurveBinding.FloatCurve("", typeof(Animator), "RootQ.w");

        AnimationUtility.SetEditorCurve(clip, s_RootTXCurveBinding, rootMotionCurves.rootTXCurve);
        AnimationUtility.SetEditorCurve(clip, s_RootTYCurveBinding, rootMotionCurves.rootTYCurve);
        AnimationUtility.SetEditorCurve(clip, s_RootTZCurveBinding, rootMotionCurves.rootTZCurve);
        AnimationUtility.SetEditorCurve(clip, s_RootQXCurveBinding, rootMotionCurves.rootQXCurve);
        AnimationUtility.SetEditorCurve(clip, s_RootQYCurveBinding, rootMotionCurves.rootQYCurve);
        AnimationUtility.SetEditorCurve(clip, s_RootQZCurveBinding, rootMotionCurves.rootQZCurve);
        AnimationUtility.SetEditorCurve(clip, s_RootQWCurveBinding, rootMotionCurves.rootQWCurve);
    }
}



