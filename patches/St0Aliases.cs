using RecompOne.Runtime.Context;
using RecompOne.Runtime.Dispatch;
using RecompOne.Runtime.Memory;

namespace Recompiled;

public static partial class SoTN_st0
{
    public static void AllocEntity_st0(CpuContext c, IMemory m) => func_801B5B04(c, m);
    public static void AnimateEntity_st0(CpuContext c, IMemory m) => func_801B5170(c, m);
    public static void ClearScreen(CpuContext c, IMemory m) => func_801B089C(c, m);
    public static void CreateEntityFromCurrentEntity_st0(CpuContext c, IMemory m) => func_801B4284(c, m);
    public static void CreateEntityFromEntity_st0(CpuContext c, IMemory m) => func_801B42F8(c, m);
    public static void CutsceneRun_st0(CpuContext c, IMemory m) => func_801A9554(c, m);
    public static void CutsceneUnk1_st0(CpuContext c, IMemory m) => func_801A9068(c, m);
    public static void CutsceneUnk3_st0(CpuContext c, IMemory m) => func_801A9290(c, m);
    public static void CutsceneUnk4_st0(CpuContext c, IMemory m) => func_801A92EC(c, m);
    public static void DestroyEntitiesFromIndex_st0(CpuContext c, IMemory m) => func_801B50AC(c, m);
    public static void DestroyEntity_st0(CpuContext c, IMemory m) => func_801B5040(c, m);
    public static void DrawCutsceneActorName_st0(CpuContext c, IMemory m) => func_801A93A4(c, m);
    public static void InitClutIndices(CpuContext c, IMemory m) => func_801B0774(c, m);
    public static void InitializeEntity_st0(CpuContext c, IMemory m) => func_801B5F84(c, m);
    public static void IsSkipRequested(CpuContext c, IMemory m) => func_801B0B30(c, m);
    public static void MoveEntity_st0(CpuContext c, IMemory m) => func_801B53F4(c, m);
    public static void PreventEntityFromRespawning_st0(CpuContext c, IMemory m) => func_801B5128(c, m);
    public static void PrimDecreaseBrightness_st0(CpuContext c, IMemory m) => func_801BDFC4(c, m);
    public static void ScaleCutsceneAvatar_st0(CpuContext c, IMemory m) => func_801A9800(c, m);
    public static void SetCutsceneEnd_st0(CpuContext c, IMemory m) => func_801A9528(c, m);
    public static void SetCutsceneScript_st0(CpuContext c, IMemory m) => func_801A90BC(c, m);
    public static void SetDisplayBufferColorsToBlack_st0(CpuContext c, IMemory m) => func_801B08DC(c, m);
    public static void SetGameState_st0(CpuContext c, IMemory m) => func_801B074C(c, m);
    public static void SetStageCinematicBorders(CpuContext c, IMemory m) => func_801B0914(c, m);
    public static void SetStageDisplayBuffer_st0(CpuContext c, IMemory m) => func_801B099C(c, m);
    public static void SetStep_st0(CpuContext c, IMemory m) => func_801B5ECC(c, m);
    public static void UnkCollisionFunc3_st0(CpuContext c, IMemory m) => func_801B5494(c, m);
    public static void Unreferenced_MAD_ST0_func_st0(CpuContext c, IMemory m) => func_801B7394(c, m);
    public static void func_801A845C(CpuContext c, IMemory m) => Dispatcher.Call(c, m, 0x801A845Cu);
    public static void func_801A8B40(CpuContext c, IMemory m) => Dispatcher.Call(c, m, 0x801A8B40u);
    public static void func_801A8C3C(CpuContext c, IMemory m) => Dispatcher.Call(c, m, 0x801A8C3Cu);
    public static void func_801AF17C(CpuContext c, IMemory m) => Dispatcher.Call(c, m, 0x801AF17Cu);
    public static void func_801AF380(CpuContext c, IMemory m) => func_801AFA9C(c, m);
    public static void func_801AF6D0(CpuContext c, IMemory m) => func_801AFDEC(c, m);
    public static void func_801B101C(CpuContext c, IMemory m) => func_801B1738(c, m);
    public static void func_801B3604(CpuContext c, IMemory m) => Dispatcher.Call(c, m, 0x801B3604u);
    public static void func_801B4D94(CpuContext c, IMemory m) => Dispatcher.Call(c, m, 0x801B4D94u);
    public static void func_801B56DC(CpuContext c, IMemory m) => Dispatcher.Call(c, m, 0x801B56DCu);
    public static void func_801BB9A8(CpuContext c, IMemory m) => Dispatcher.Call(c, m, 0x801BB9A8u);
    public static void func_801BD0D0(CpuContext c, IMemory m) => Dispatcher.Call(c, m, 0x801BD0D0u);
}
