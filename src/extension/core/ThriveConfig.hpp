#pragma once

#include <godot_cpp/classes/object.hpp>

#include "Include.h"

#include "core/NativeLibIntercommunication.hpp"

namespace Thrive
{

/// \brief Manages forwarding C# side configuration and other runtime data between Thrive parts into this module
class ThriveConfig : public godot::Object
{
    GDCLASS(ThriveConfig, godot::Object)
public:
    // ------------------------------------ //
    // Static access to this class to access configuration data. Invalid if this hasn't been initialized by the C#
    // code yet.

public:
    ThriveConfig() = default;
    ~ThriveConfig() override;

    /// \brief Checks that other running Thrive components are compatible
    bool ReportOtherVersions(int csharpVersion, int nativeLibraryVersion) noexcept;

    /// \brief Wrapper for InitializeImplementation to be called through Godot
    godot::Variant Initialize(const godot::Variant& intercommunication) noexcept;

    ThriveConfig* InitializeImplementation(NativeLibIntercommunication& intercommunication) noexcept;

    /// \brief Shuts down this extension. Returns true on success (fails if not initialized)
    bool Shutdown() noexcept;

    // ------------------------------------ //
    // C# interop methods
    [[nodiscard]] int GetVersion() const noexcept;

protected:
    static void _bind_methods();

private:
    bool initialized = false;
};

} // namespace Thrive