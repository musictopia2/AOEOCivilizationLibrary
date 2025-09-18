namespace AOEOCivilizationLibrary.ApplicationState;
/// <summary>
/// Defines the contract for evaluating and handling civilization changes during a session.
/// </summary>
/// <remarks>
/// This interface is part of the core civilization tracking system but is intended primarily for
/// advanced usage scenarios where custom civilization change evaluation logic is required.
///
/// For most consumers of the <c>AOEOCivilizationLibrary</c>, this interface will not need to be
/// implemented or interacted with directly. The default implementations provided by dependent
/// systems (such as music or quest systems) handle civilization changes automatically.
///
/// Implementers of this interface can integrate custom logic to evaluate whether a civilization
/// change should occur, and to perform any related side-effects.
///
/// <para><b>Note:</b> This interface is typically registered and resolved via dependency injection,
/// allowing different implementations depending on runtime context (e.g., offline vs online mode).
/// Usually used for offline systems since that has detectors for when a quest ended unlike online that usually
/// requires hitting a hotkey to force it.   that was already done for that purpose.
/// </para>
/// </remarks>
public interface ICivilizationChangeEvaluator
{
    /// <summary>
    /// Evaluates whether a civilization change should be triggered, and performs necessary updates.
    /// </summary>
    /// <returns>A task representing the asynchronous evaluation operation.</returns>
    Task EvaluateChangeAsync();
}