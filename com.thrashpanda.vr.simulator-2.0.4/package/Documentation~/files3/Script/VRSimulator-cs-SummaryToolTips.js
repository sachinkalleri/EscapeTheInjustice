NDSummary.OnToolTipsLoaded("File3:Script/VRSimulator.cs",{59:"<div class=\"NDToolTip TClass LCSharp\"><div class=\"NDClassPrototype\" id=\"NDClassPrototype59\"><div class=\"CPEntry TClass Current\"><div class=\"CPModifiers\"><span class=\"SHKeyword\">public</span></div><div class=\"CPName\">VRSimulator</div></div></div><div class=\"TTSummary\">The main class of the VR Simulator. Defines functions to control a VRSimulatorHMD and two VRSimulatorController.</div></div>",61:"<div class=\"NDToolTip TVariable LCSharp\"><div id=\"NDPrototype61\" class=\"NDPrototype NoParameterForm\"><div class=\"PPrePrototypeLine\"><span class=\"SHMetadata\">[SerializeField]</span></div><span class=\"SHKeyword\">public</span> Transform xRRigToFollow</div><div class=\"TTSummary\">A Transform the virtual rig will match position and rotation to. Needs to be assigned in order to match the simulated controllers with the XR controllers in the scene.</div></div>",62:"<div class=\"NDToolTip TVariable LCSharp\"><div id=\"NDPrototype62\" class=\"NDPrototype NoParameterForm\"><span class=\"SHKeyword\">private</span> Transform simulatorRig</div><div class=\"TTSummary\">The transform of the simulator rig. Should be identical to this components transform.</div></div>",63:"<div class=\"NDToolTip TVariable LCSharp\"><div id=\"NDPrototype63\" class=\"NDPrototype NoParameterForm\"><div class=\"PPrePrototypeLine\"><span class=\"SHMetadata\">[SerializeField]</span></div>VRSimulatorHMD simulatorHMD</div><div class=\"TTSummary\">The simulated hmd that can be controlled.</div></div>",64:"<div class=\"NDToolTip TVariable LCSharp\"><div id=\"NDPrototype64\" class=\"NDPrototype NoParameterForm\"><span class=\"SHKeyword\">private</span> Transform hmd</div><div class=\"TTSummary\">The transform of the simulated hmd that can be controlled.</div></div>",65:"<div class=\"NDToolTip TVariable LCSharp\"><div id=\"NDPrototype65\" class=\"NDPrototype NoParameterForm\"><div class=\"PPrePrototypeLine\"><span class=\"SHMetadata\">[SerializeField]</span></div>VRSimulatorController simulatorControllerL</div><div class=\"TTSummary\">The left simulated controller that can be controlled.</div></div>",66:"<div class=\"NDToolTip TVariable LCSharp\"><div id=\"NDPrototype66\" class=\"NDPrototype NoParameterForm\"><span class=\"SHKeyword\">private</span> Transform controllerL</div><div class=\"TTSummary\">The transform of the left simulated controller that can be controlled.</div></div>",67:"<div class=\"NDToolTip TVariable LCSharp\"><div id=\"NDPrototype67\" class=\"NDPrototype NoParameterForm\"><div class=\"PPrePrototypeLine\"><span class=\"SHMetadata\">[SerializeField]</span></div>VRSimulatorController simulatorControllerR</div><div class=\"TTSummary\">The right simulated controller that can be controlled.</div></div>",68:"<div class=\"NDToolTip TVariable LCSharp\"><div id=\"NDPrototype68\" class=\"NDPrototype NoParameterForm\"><span class=\"SHKeyword\">private</span> Transform controllerR</div><div class=\"TTSummary\">The transform of the right simulated controller that can be controlled.</div></div>",69:"<div class=\"NDToolTip TVariable LCSharp\"><div id=\"NDPrototype69\" class=\"NDPrototype NoParameterForm\"><div class=\"PPrePrototypeLine\"><span class=\"SHMetadata\">[SerializeField]</span></div><span class=\"SHKeyword\">private</span> Vector3 leftControllerRestPosition</div><div class=\"TTSummary\">The rest position of controllerL relative to hmd.</div></div>",70:"<div class=\"NDToolTip TVariable LCSharp\"><div id=\"NDPrototype70\" class=\"NDPrototype NoParameterForm\"><span class=\"SHKeyword\">private</span> Quaternion leftControllerRestRotation</div><div class=\"TTSummary\">The rest rotation of controllerL relative to hmd.</div></div>",71:"<div class=\"NDToolTip TVariable LCSharp\"><div id=\"NDPrototype71\" class=\"NDPrototype NoParameterForm\"><div class=\"PPrePrototypeLine\"><span class=\"SHMetadata\">[SerializeField]</span></div><span class=\"SHKeyword\">private</span> Vector3 rightControllerRestPosition</div><div class=\"TTSummary\">The rest position of controllerR relative to hmd.</div></div>",72:"<div class=\"NDToolTip TVariable LCSharp\"><div id=\"NDPrototype72\" class=\"NDPrototype NoParameterForm\"><span class=\"SHKeyword\">private</span> Quaternion rightControllerRestRotation</div><div class=\"TTSummary\">The rest rotation of controllerR relative to hmd.</div></div>",73:"<div class=\"NDToolTip TVariable LCSharp\"><div id=\"NDPrototype73\" class=\"NDPrototype NoParameterForm\"><div class=\"PPrePrototypeLine\"><span class=\"SHMetadata\">[SerializeField]</span></div><span class=\"SHKeyword\">private bool</span> showDirectionHelpers</div><div class=\"TTSummary\">Bool that decides wether the direction helpers will be displayed. This will default to false if no xRRigToFollow is assigned.</div></div>",74:"<div class=\"NDToolTip TVariable LCSharp\"><div id=\"NDPrototype74\" class=\"NDPrototype NoParameterForm\"><div class=\"PPrePrototypeLine\"><span class=\"SHMetadata\">[SerializeField]</span></div><span class=\"SHKeyword\">private</span> GameObject directionPrefab</div><div class=\"TTSummary\">GameObject that gets instantiated per controller and will be shown if showDirectionHelpers is true.</div></div>",75:"<div class=\"NDToolTip TVariable LCSharp\"><div id=\"NDPrototype75\" class=\"NDPrototype NoParameterForm\"><span class=\"SHKeyword\">private</span> GameObject directionsLeft</div><div class=\"TTSummary\">Reference to the instantiated directionPrefab for the left controller.</div></div>",76:"<div class=\"NDToolTip TVariable LCSharp\"><div id=\"NDPrototype76\" class=\"NDPrototype NoParameterForm\"><span class=\"SHKeyword\">private</span> GameObject directionsRight</div><div class=\"TTSummary\">Reference to the instantiated directionPrefab for the right controller.</div></div>",77:"<div class=\"NDToolTip TVariable LCSharp\"><div id=\"NDPrototype77\" class=\"NDPrototype NoParameterForm\"><span class=\"SHKeyword\">internal bool</span> rotateHands</div></div>",78:"<div class=\"NDToolTip TVariable LCSharp\"><div id=\"NDPrototype78\" class=\"NDPrototype NoParameterForm\"><span class=\"SHKeyword\">private</span> GameObject rotationHelper</div></div>",79:"<div class=\"NDToolTip TVariable LCSharp\"><div id=\"NDPrototype79\" class=\"NDPrototype NoParameterForm\"><div class=\"PPrePrototypeLine\"><span class=\"SHMetadata\">[SerializeField]</span></div>TrackingOriginModeFlags trackingOriginMode</div><div class=\"TTSummary\">Sets the tracking origin mode for the simulator. Needs to match the TrackingOriginModeFlags of the XRRig. If set to Floor the headsetHeight will be considered.</div></div>",80:"<div class=\"NDToolTip TVariable LCSharp\"><div id=\"NDPrototype80\" class=\"NDPrototype NoParameterForm\"><div class=\"PPrePrototypeLine\"><span class=\"SHMetadata\">[SerializeField]</span></div><span class=\"SHKeyword\">private float</span> headsetHeight</div><div class=\"TTSummary\">Offset of the simulated hmd from the ground. Will only be considered if trackingOriginMode is set to Floor.</div></div>",81:"<div class=\"NDToolTip TVariable LCSharp\"><div id=\"NDPrototype81\" class=\"NDPrototype NoParameterForm\"><span class=\"SHKeyword\">internal bool</span> handsActive</div></div>",82:"<div class=\"NDToolTip TVariable LCSharp\"><div id=\"NDPrototype82\" class=\"NDPrototype NoParameterForm\"><span class=\"SHKeyword\">internal bool</span> switchHand</div></div>",83:"<div class=\"NDToolTip TVariable LCSharp\"><div id=\"NDPrototype83\" class=\"NDPrototype NoParameterForm\"><span class=\"SHKeyword\">internal bool</span> switchHandAxis</div></div>",85:"<div class=\"NDToolTip TFunction LCSharp\"><div id=\"NDPrototype85\" class=\"NDPrototype NoParameterForm\"><span class=\"SHKeyword\">void</span> Start()</div></div>",86:"<div class=\"NDToolTip TFunction LCSharp\"><div id=\"NDPrototype86\" class=\"NDPrototype NoParameterForm\"><span class=\"SHKeyword\">private void</span> Init()</div><div class=\"TTSummary\">Initializes the simulator.</div></div>",87:"<div class=\"NDToolTip TFunction LCSharp\"><div id=\"NDPrototype87\" class=\"NDPrototype NoParameterForm\"><span class=\"SHKeyword\">private void</span> InitVariables()</div><div class=\"TTSummary\">Assigns transforms to  simulatorRig, hmd, controllerL, controllerR and instatiates the direction helpers.</div></div>",88:"<div class=\"NDToolTip TFunction LCSharp\"><div id=\"NDPrototype88\" class=\"NDPrototype NoParameterForm\"><span class=\"SHKeyword\">private void</span> InitTrackingMode()</div><div class=\"TTSummary\">Sets the hmd position to headsetHeight if trackingOriginMode is set to Floor.</div></div>",89:"<div class=\"NDToolTip TFunction LCSharp\"><div id=\"NDPrototype89\" class=\"NDPrototype NoParameterForm\"><span class=\"SHKeyword\">internal void</span> ResetControllers()</div><div class=\"TTSummary\">Resets position and rotation of the controllers.</div></div>",90:"<div class=\"NDToolTip TFunction LCSharp\"><div id=\"NDPrototype90\" class=\"NDPrototype NoParameterForm\"><span class=\"SHKeyword\">void</span> UpdateDirectionsHelper()</div><div class=\"TTSummary\">Shows or hides the direction helper objects directionsRight and directionsLeft depending on handsActive and showDirectionHelpers.</div></div>",91:"<div class=\"NDToolTip TFunction LCSharp\"><div id=\"NDPrototype91\" class=\"NDPrototype WideForm CStyle\"><table><tr><td class=\"PBeforeParameters\"><span class=\"SHKeyword\">internal void</span> RotateHeadset(</td><td class=\"PParametersParentCell\"><table class=\"PParameters\"><tr><td class=\"PType first\">Vector3&nbsp;</td><td class=\"PName last\">angle</td></tr></table></td><td class=\"PAfterParameters\">)</td></tr></table></div><div class=\"TTSummary\">Rotates hmd the specified degrees defined by the given euler rotation.</div></div>",92:"<div class=\"NDToolTip TFunction LCSharp\"><div id=\"NDPrototype92\" class=\"NDPrototype WideForm CStyle\"><table><tr><td class=\"PBeforeParameters\"><span class=\"SHKeyword\">internal void</span> MoveController(</td><td class=\"PParametersParentCell\"><table class=\"PParameters\"><tr><td class=\"PType first\"><span class=\"SHKeyword\">bool</span>&nbsp;</td><td class=\"PName last\">left,</td></tr><tr><td class=\"PType first\">Vector3&nbsp;</td><td class=\"PName last\">translation</td></tr></table></td><td class=\"PAfterParameters\">)</td></tr></table></div><div class=\"TTSummary\">Moves either the left or the right controller by the given translation.</div></div>",93:"<div class=\"NDToolTip TFunction LCSharp\"><div id=\"NDPrototype93\" class=\"NDPrototype WideForm CStyle\"><table><tr><td class=\"PBeforeParameters\"><span class=\"SHKeyword\">internal void</span> RotateController(</td><td class=\"PParametersParentCell\"><table class=\"PParameters\"><tr><td class=\"PType first\"><span class=\"SHKeyword\">bool</span>&nbsp;</td><td class=\"PName last\">left,</td></tr><tr><td class=\"PType first\">Vector3&nbsp;</td><td class=\"PName last\">rotation</td></tr></table></td><td class=\"PAfterParameters\">)</td></tr></table></div><div class=\"TTSummary\">Rotates either the left or the right controller by the given euler angles.</div></div>",94:"<div class=\"NDToolTip TFunction LCSharp\"><div id=\"NDPrototype94\" class=\"NDPrototype NoParameterForm\"><span class=\"SHKeyword\">void</span> Update()</div></div>",95:"<div class=\"NDToolTip TFunction LCSharp\"><div id=\"NDPrototype95\" class=\"NDPrototype WideForm CStyle\"><table><tr><td class=\"PBeforeParameters\"><span class=\"SHKeyword\">public void</span> Move(</td><td class=\"PParametersParentCell\"><table class=\"PParameters\"><tr><td class=\"PType first\">Vector2&nbsp;</td><td class=\"PName last\">direction</td></tr></table></td><td class=\"PAfterParameters\">)</td></tr></table></div><div class=\"TTSummary\">Moves hmd horizontally by the given translation relative to simulatorRig.</div></div>"});