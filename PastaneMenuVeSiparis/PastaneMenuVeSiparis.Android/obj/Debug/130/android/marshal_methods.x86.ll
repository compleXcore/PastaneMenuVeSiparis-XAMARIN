; ModuleID = 'obj\Debug\130\android\marshal_methods.x86.ll'
source_filename = "obj\Debug\130\android\marshal_methods.x86.ll"
target datalayout = "e-m:e-p:32:32-p270:32:32-p271:32:32-p272:64:64-f64:32:64-f80:32-n8:16:32-S128"
target triple = "i686-unknown-linux-android"


%struct.MonoImage = type opaque

%struct.MonoClass = type opaque

%struct.MarshalMethodsManagedClass = type {
	i32,; uint32_t token
	%struct.MonoClass*; MonoClass* klass
}

%struct.MarshalMethodName = type {
	i64,; uint64_t id
	i8*; char* name
}

%class._JNIEnv = type opaque

%class._jobject = type {
	i8; uint8_t b
}

%class._jclass = type {
	i8; uint8_t b
}

%class._jstring = type {
	i8; uint8_t b
}

%class._jthrowable = type {
	i8; uint8_t b
}

%class._jarray = type {
	i8; uint8_t b
}

%class._jobjectArray = type {
	i8; uint8_t b
}

%class._jbooleanArray = type {
	i8; uint8_t b
}

%class._jbyteArray = type {
	i8; uint8_t b
}

%class._jcharArray = type {
	i8; uint8_t b
}

%class._jshortArray = type {
	i8; uint8_t b
}

%class._jintArray = type {
	i8; uint8_t b
}

%class._jlongArray = type {
	i8; uint8_t b
}

%class._jfloatArray = type {
	i8; uint8_t b
}

%class._jdoubleArray = type {
	i8; uint8_t b
}

; assembly_image_cache
@assembly_image_cache = local_unnamed_addr global [0 x %struct.MonoImage*] zeroinitializer, align 4
; Each entry maps hash of an assembly name to an index into the `assembly_image_cache` array
@assembly_image_cache_hashes = local_unnamed_addr constant [234 x i32] [
	i32 32687329, ; 0: Xamarin.AndroidX.Lifecycle.Runtime => 0x1f2c4e1 => 57
	i32 34715100, ; 1: Xamarin.Google.Guava.ListenableFuture.dll => 0x211b5dc => 86
	i32 39109920, ; 2: Newtonsoft.Json.dll => 0x254c520 => 9
	i32 57263871, ; 3: Xamarin.Forms.Core.dll => 0x369c6ff => 81
	i32 101534019, ; 4: Xamarin.AndroidX.SlidingPaneLayout => 0x60d4943 => 71
	i32 120558881, ; 5: Xamarin.AndroidX.SlidingPaneLayout.dll => 0x72f9521 => 71
	i32 165246403, ; 6: Xamarin.AndroidX.Collection.dll => 0x9d975c3 => 38
	i32 182336117, ; 7: Xamarin.AndroidX.SwipeRefreshLayout.dll => 0xade3a75 => 72
	i32 209399409, ; 8: Xamarin.AndroidX.Browser.dll => 0xc7b2e71 => 36
	i32 220171995, ; 9: System.Diagnostics.Debug => 0xd1f8edb => 99
	i32 230216969, ; 10: Xamarin.AndroidX.Legacy.Support.Core.Utils.dll => 0xdb8d509 => 52
	i32 230752869, ; 11: Microsoft.CSharp.dll => 0xdc10265 => 107
	i32 231814094, ; 12: System.Globalization => 0xdd133ce => 93
	i32 232815796, ; 13: System.Web.Services => 0xde07cb4 => 115
	i32 261689757, ; 14: Xamarin.AndroidX.ConstraintLayout.dll => 0xf99119d => 41
	i32 278686392, ; 15: Xamarin.AndroidX.Lifecycle.LiveData.dll => 0x109c6ab8 => 56
	i32 280482487, ; 16: Xamarin.AndroidX.Interpolator => 0x10b7d2b7 => 50
	i32 318968648, ; 17: Xamarin.AndroidX.Activity.dll => 0x13031348 => 28
	i32 321597661, ; 18: System.Numerics => 0x132b30dd => 22
	i32 342366114, ; 19: Xamarin.AndroidX.Lifecycle.Common => 0x146817a2 => 54
	i32 347068432, ; 20: SQLitePCLRaw.lib.e_sqlite3.android.dll => 0x14afd810 => 16
	i32 385762202, ; 21: System.Memory.dll => 0x16fe439a => 21
	i32 441335492, ; 22: Xamarin.AndroidX.ConstraintLayout.Core => 0x1a4e3ec4 => 40
	i32 442521989, ; 23: Xamarin.Essentials => 0x1a605985 => 80
	i32 442565967, ; 24: System.Collections => 0x1a61054f => 92
	i32 450948140, ; 25: Xamarin.AndroidX.Fragment.dll => 0x1ae0ec2c => 49
	i32 459347974, ; 26: System.Runtime.Serialization.Primitives.dll => 0x1b611806 => 94
	i32 465846621, ; 27: mscorlib => 0x1bc4415d => 8
	i32 469710990, ; 28: System.dll => 0x1bff388e => 20
	i32 476646585, ; 29: Xamarin.AndroidX.Interpolator.dll => 0x1c690cb9 => 50
	i32 486930444, ; 30: Xamarin.AndroidX.LocalBroadcastManager.dll => 0x1d05f80c => 61
	i32 498788369, ; 31: System.ObjectModel => 0x1dbae811 => 100
	i32 526420162, ; 32: System.Transactions.dll => 0x1f6088c2 => 110
	i32 529200002, ; 33: PastaneMenuVeSiparis => 0x1f8af382 => 10
	i32 545304856, ; 34: System.Runtime.Extensions => 0x2080b118 => 104
	i32 605376203, ; 35: System.IO.Compression.FileSystem => 0x24154ecb => 113
	i32 627609679, ; 36: Xamarin.AndroidX.CustomView => 0x2568904f => 45
	i32 663517072, ; 37: Xamarin.AndroidX.VersionedParcelable => 0x278c7790 => 77
	i32 666292255, ; 38: Xamarin.AndroidX.Arch.Core.Common.dll => 0x27b6d01f => 33
	i32 690569205, ; 39: System.Xml.Linq.dll => 0x29293ff5 => 27
	i32 748832960, ; 40: SQLitePCLRaw.batteries_v2 => 0x2ca248c0 => 14
	i32 775507847, ; 41: System.IO.Compression => 0x2e394f87 => 112
	i32 800472933, ; 42: SQLiteNetExtensionsAsync => 0x2fb63f65 => 13
	i32 809851609, ; 43: System.Drawing.Common.dll => 0x30455ad9 => 88
	i32 843511501, ; 44: Xamarin.AndroidX.Print => 0x3246f6cd => 68
	i32 877678880, ; 45: System.Globalization.dll => 0x34505120 => 93
	i32 928116545, ; 46: Xamarin.Google.Guava.ListenableFuture => 0x3751ef41 => 86
	i32 955402788, ; 47: Newtonsoft.Json => 0x38f24a24 => 9
	i32 967690846, ; 48: Xamarin.AndroidX.Lifecycle.Common.dll => 0x39adca5e => 54
	i32 974778368, ; 49: FormsViewGroup.dll => 0x3a19f000 => 5
	i32 975874589, ; 50: System.Xml.XDocument => 0x3a2aaa1d => 91
	i32 992768348, ; 51: System.Collections.dll => 0x3b2c715c => 92
	i32 1012816738, ; 52: Xamarin.AndroidX.SavedState.dll => 0x3c5e5b62 => 70
	i32 1035644815, ; 53: Xamarin.AndroidX.AppCompat => 0x3dbaaf8f => 32
	i32 1042160112, ; 54: Xamarin.Forms.Platform.dll => 0x3e1e19f0 => 83
	i32 1044663988, ; 55: System.Linq.Expressions.dll => 0x3e444eb4 => 96
	i32 1052210849, ; 56: Xamarin.AndroidX.Lifecycle.ViewModel.dll => 0x3eb776a1 => 58
	i32 1098259244, ; 57: System => 0x41761b2c => 20
	i32 1175144683, ; 58: Xamarin.AndroidX.VectorDrawable.Animated => 0x460b48eb => 75
	i32 1178241025, ; 59: Xamarin.AndroidX.Navigation.Runtime.dll => 0x463a8801 => 65
	i32 1204270330, ; 60: Xamarin.AndroidX.Arch.Core.Common => 0x47c7b4fa => 33
	i32 1267360935, ; 61: Xamarin.AndroidX.VectorDrawable => 0x4b8a64a7 => 76
	i32 1292207520, ; 62: SQLitePCLRaw.core.dll => 0x4d0585a0 => 15
	i32 1293217323, ; 63: Xamarin.AndroidX.DrawerLayout.dll => 0x4d14ee2b => 47
	i32 1324164729, ; 64: System.Linq => 0x4eed2679 => 98
	i32 1364015309, ; 65: System.IO => 0x514d38cd => 89
	i32 1365406463, ; 66: System.ServiceModel.Internals.dll => 0x516272ff => 87
	i32 1376866003, ; 67: Xamarin.AndroidX.SavedState => 0x52114ed3 => 70
	i32 1379779777, ; 68: System.Resources.ResourceManager => 0x523dc4c1 => 2
	i32 1395857551, ; 69: Xamarin.AndroidX.Media.dll => 0x5333188f => 62
	i32 1406073936, ; 70: Xamarin.AndroidX.CoordinatorLayout => 0x53cefc50 => 42
	i32 1411638395, ; 71: System.Runtime.CompilerServices.Unsafe => 0x5423e47b => 24
	i32 1457743152, ; 72: System.Runtime.Extensions.dll => 0x56e36530 => 104
	i32 1460219004, ; 73: Xamarin.Forms.Xaml => 0x57092c7c => 84
	i32 1462112819, ; 74: System.IO.Compression.dll => 0x57261233 => 112
	i32 1469204771, ; 75: Xamarin.AndroidX.AppCompat.AppCompatResources => 0x57924923 => 31
	i32 1543031311, ; 76: System.Text.RegularExpressions.dll => 0x5bf8ca0f => 101
	i32 1550322496, ; 77: System.Reflection.Extensions.dll => 0x5c680b40 => 1
	i32 1575841586, ; 78: PastaneMenuVeSiparis.Android.dll => 0x5ded6f32 => 0
	i32 1582372066, ; 79: Xamarin.AndroidX.DocumentFile.dll => 0x5e5114e2 => 46
	i32 1592978981, ; 80: System.Runtime.Serialization.dll => 0x5ef2ee25 => 4
	i32 1604451928, ; 81: SQLiteNetExtensions => 0x5fa1fe58 => 12
	i32 1622152042, ; 82: Xamarin.AndroidX.Loader.dll => 0x60b0136a => 60
	i32 1622358360, ; 83: System.Dynamic.Runtime => 0x60b33958 => 97
	i32 1624863272, ; 84: Xamarin.AndroidX.ViewPager2 => 0x60d97228 => 79
	i32 1636350590, ; 85: Xamarin.AndroidX.CursorAdapter => 0x6188ba7e => 44
	i32 1639515021, ; 86: System.Net.Http.dll => 0x61b9038d => 3
	i32 1639986890, ; 87: System.Text.RegularExpressions => 0x61c036ca => 101
	i32 1657153582, ; 88: System.Runtime => 0x62c6282e => 25
	i32 1658241508, ; 89: Xamarin.AndroidX.Tracing.Tracing.dll => 0x62d6c1e4 => 73
	i32 1658251792, ; 90: Xamarin.Google.Android.Material.dll => 0x62d6ea10 => 85
	i32 1666713512, ; 91: SQLiteNetExtensions.dll => 0x635807a8 => 12
	i32 1670060433, ; 92: Xamarin.AndroidX.ConstraintLayout => 0x638b1991 => 41
	i32 1701541528, ; 93: System.Diagnostics.Debug.dll => 0x656b7698 => 99
	i32 1711441057, ; 94: SQLitePCLRaw.lib.e_sqlite3.android => 0x660284a1 => 16
	i32 1726116996, ; 95: System.Reflection.dll => 0x66e27484 => 95
	i32 1729485958, ; 96: Xamarin.AndroidX.CardView.dll => 0x6715dc86 => 37
	i32 1765942094, ; 97: System.Reflection.Extensions => 0x6942234e => 1
	i32 1766324549, ; 98: Xamarin.AndroidX.SwipeRefreshLayout => 0x6947f945 => 72
	i32 1776026572, ; 99: System.Core.dll => 0x69dc03cc => 19
	i32 1788241197, ; 100: Xamarin.AndroidX.Fragment => 0x6a96652d => 49
	i32 1808609942, ; 101: Xamarin.AndroidX.Loader => 0x6bcd3296 => 60
	i32 1813201214, ; 102: Xamarin.Google.Android.Material => 0x6c13413e => 85
	i32 1818569960, ; 103: Xamarin.AndroidX.Navigation.UI.dll => 0x6c652ce8 => 66
	i32 1824175904, ; 104: System.Text.Encoding.Extensions => 0x6cbab720 => 106
	i32 1858542181, ; 105: System.Linq.Expressions => 0x6ec71a65 => 96
	i32 1867746548, ; 106: Xamarin.Essentials.dll => 0x6f538cf4 => 80
	i32 1878053835, ; 107: Xamarin.Forms.Xaml.dll => 0x6ff0d3cb => 84
	i32 1885316902, ; 108: Xamarin.AndroidX.Arch.Core.Runtime.dll => 0x705fa726 => 34
	i32 1900610850, ; 109: System.Resources.ResourceManager.dll => 0x71490522 => 2
	i32 1919157823, ; 110: Xamarin.AndroidX.MultiDex.dll => 0x7264063f => 63
	i32 2011961780, ; 111: System.Buffers.dll => 0x77ec19b4 => 18
	i32 2019465201, ; 112: Xamarin.AndroidX.Lifecycle.ViewModel => 0x785e97f1 => 58
	i32 2055257422, ; 113: Xamarin.AndroidX.Lifecycle.LiveData.Core.dll => 0x7a80bd4e => 55
	i32 2079903147, ; 114: System.Runtime.dll => 0x7bf8cdab => 25
	i32 2090596640, ; 115: System.Numerics.Vectors => 0x7c9bf920 => 23
	i32 2097448633, ; 116: Xamarin.AndroidX.Legacy.Support.Core.UI => 0x7d0486b9 => 51
	i32 2103459038, ; 117: SQLitePCLRaw.provider.e_sqlite3.dll => 0x7d603cde => 17
	i32 2126786730, ; 118: Xamarin.Forms.Platform.Android => 0x7ec430aa => 82
	i32 2193016926, ; 119: System.ObjectModel.dll => 0x82b6c85e => 100
	i32 2201231467, ; 120: System.Net.Http => 0x8334206b => 3
	i32 2217644978, ; 121: Xamarin.AndroidX.VectorDrawable.Animated.dll => 0x842e93b2 => 75
	i32 2244775296, ; 122: Xamarin.AndroidX.LocalBroadcastManager => 0x85cc8d80 => 61
	i32 2256548716, ; 123: Xamarin.AndroidX.MultiDex => 0x8680336c => 63
	i32 2261435625, ; 124: Xamarin.AndroidX.Legacy.Support.V4.dll => 0x86cac4e9 => 53
	i32 2279755925, ; 125: Xamarin.AndroidX.RecyclerView.dll => 0x87e25095 => 69
	i32 2315684594, ; 126: Xamarin.AndroidX.Annotation.dll => 0x8a068af2 => 29
	i32 2368005991, ; 127: System.Xml.ReaderWriter.dll => 0x8d24e767 => 102
	i32 2409053734, ; 128: Xamarin.AndroidX.Preference.dll => 0x8f973e26 => 67
	i32 2454642406, ; 129: System.Text.Encoding.dll => 0x924edee6 => 103
	i32 2465273461, ; 130: SQLitePCLRaw.batteries_v2.dll => 0x92f11675 => 14
	i32 2465532216, ; 131: Xamarin.AndroidX.ConstraintLayout.Core.dll => 0x92f50938 => 40
	i32 2471841756, ; 132: netstandard.dll => 0x93554fdc => 108
	i32 2475788418, ; 133: Java.Interop.dll => 0x93918882 => 6
	i32 2501346920, ; 134: System.Data.DataSetExtensions => 0x95178668 => 111
	i32 2505896520, ; 135: Xamarin.AndroidX.Lifecycle.Runtime.dll => 0x955cf248 => 57
	i32 2562349572, ; 136: Microsoft.CSharp => 0x98ba5a04 => 107
	i32 2581819634, ; 137: Xamarin.AndroidX.VectorDrawable.dll => 0x99e370f2 => 76
	i32 2585220780, ; 138: System.Text.Encoding.Extensions.dll => 0x9a1756ac => 106
	i32 2620871830, ; 139: Xamarin.AndroidX.CursorAdapter.dll => 0x9c375496 => 44
	i32 2624644809, ; 140: Xamarin.AndroidX.DynamicAnimation => 0x9c70e6c9 => 48
	i32 2633051222, ; 141: Xamarin.AndroidX.Lifecycle.LiveData => 0x9cf12c56 => 56
	i32 2664396074, ; 142: System.Xml.XDocument.dll => 0x9ecf752a => 91
	i32 2693849962, ; 143: System.IO.dll => 0xa090e36a => 89
	i32 2701096212, ; 144: Xamarin.AndroidX.Tracing.Tracing => 0xa0ff7514 => 73
	i32 2715334215, ; 145: System.Threading.Tasks.dll => 0xa1d8b647 => 90
	i32 2732626843, ; 146: Xamarin.AndroidX.Activity => 0xa2e0939b => 28
	i32 2733349394, ; 147: PastaneMenuVeSiparis.dll => 0xa2eb9a12 => 10
	i32 2737747696, ; 148: Xamarin.AndroidX.AppCompat.AppCompatResources.dll => 0xa32eb6f0 => 31
	i32 2766581644, ; 149: Xamarin.Forms.Core => 0xa4e6af8c => 81
	i32 2778768386, ; 150: Xamarin.AndroidX.ViewPager.dll => 0xa5a0a402 => 78
	i32 2810250172, ; 151: Xamarin.AndroidX.CoordinatorLayout.dll => 0xa78103bc => 42
	i32 2819470561, ; 152: System.Xml.dll => 0xa80db4e1 => 26
	i32 2853208004, ; 153: Xamarin.AndroidX.ViewPager => 0xaa107fc4 => 78
	i32 2855708567, ; 154: Xamarin.AndroidX.Transition => 0xaa36a797 => 74
	i32 2900621748, ; 155: System.Dynamic.Runtime.dll => 0xace3f9b4 => 97
	i32 2901442782, ; 156: System.Reflection => 0xacf080de => 95
	i32 2903344695, ; 157: System.ComponentModel.Composition => 0xad0d8637 => 114
	i32 2905242038, ; 158: mscorlib.dll => 0xad2a79b6 => 8
	i32 2916838712, ; 159: Xamarin.AndroidX.ViewPager2.dll => 0xaddb6d38 => 79
	i32 2919462931, ; 160: System.Numerics.Vectors.dll => 0xae037813 => 23
	i32 2921128767, ; 161: Xamarin.AndroidX.Annotation.Experimental.dll => 0xae1ce33f => 30
	i32 2978675010, ; 162: Xamarin.AndroidX.DrawerLayout => 0xb18af942 => 47
	i32 3024354802, ; 163: Xamarin.AndroidX.Legacy.Support.Core.Utils => 0xb443fdf2 => 52
	i32 3044182254, ; 164: FormsViewGroup => 0xb57288ee => 5
	i32 3057625584, ; 165: Xamarin.AndroidX.Navigation.Common => 0xb63fa9f0 => 64
	i32 3075834255, ; 166: System.Threading.Tasks => 0xb755818f => 90
	i32 3111772706, ; 167: System.Runtime.Serialization => 0xb979e222 => 4
	i32 3204380047, ; 168: System.Data.dll => 0xbefef58f => 109
	i32 3211777861, ; 169: Xamarin.AndroidX.DocumentFile => 0xbf6fd745 => 46
	i32 3213703766, ; 170: PastaneMenuVeSiparis.Android => 0xbf8d3a56 => 0
	i32 3220365878, ; 171: System.Threading => 0xbff2e236 => 105
	i32 3247949154, ; 172: Mono.Security => 0xc197c562 => 116
	i32 3258312781, ; 173: Xamarin.AndroidX.CardView => 0xc235e84d => 37
	i32 3267021929, ; 174: Xamarin.AndroidX.AsyncLayoutInflater => 0xc2bacc69 => 35
	i32 3286872994, ; 175: SQLite-net.dll => 0xc3e9b3a2 => 11
	i32 3299363146, ; 176: System.Text.Encoding => 0xc4a8494a => 103
	i32 3317135071, ; 177: Xamarin.AndroidX.CustomView.dll => 0xc5b776df => 45
	i32 3317144872, ; 178: System.Data => 0xc5b79d28 => 109
	i32 3340431453, ; 179: Xamarin.AndroidX.Arch.Core.Runtime => 0xc71af05d => 34
	i32 3346324047, ; 180: Xamarin.AndroidX.Navigation.Runtime => 0xc774da4f => 65
	i32 3353484488, ; 181: Xamarin.AndroidX.Legacy.Support.Core.UI.dll => 0xc7e21cc8 => 51
	i32 3360279109, ; 182: SQLitePCLRaw.core => 0xc849ca45 => 15
	i32 3362522851, ; 183: Xamarin.AndroidX.Core => 0xc86c06e3 => 43
	i32 3366347497, ; 184: Java.Interop => 0xc8a662e9 => 6
	i32 3374999561, ; 185: Xamarin.AndroidX.RecyclerView => 0xc92a6809 => 69
	i32 3395150330, ; 186: System.Runtime.CompilerServices.Unsafe.dll => 0xca5de1fa => 24
	i32 3404865022, ; 187: System.ServiceModel.Internals => 0xcaf21dfe => 87
	i32 3429136800, ; 188: System.Xml => 0xcc6479a0 => 26
	i32 3430777524, ; 189: netstandard => 0xcc7d82b4 => 108
	i32 3441283291, ; 190: Xamarin.AndroidX.DynamicAnimation.dll => 0xcd1dd0db => 48
	i32 3476120550, ; 191: Mono.Android => 0xcf3163e6 => 7
	i32 3486566296, ; 192: System.Transactions => 0xcfd0c798 => 110
	i32 3493954962, ; 193: Xamarin.AndroidX.Concurrent.Futures.dll => 0xd0418592 => 39
	i32 3501239056, ; 194: Xamarin.AndroidX.AsyncLayoutInflater.dll => 0xd0b0ab10 => 35
	i32 3509114376, ; 195: System.Xml.Linq => 0xd128d608 => 27
	i32 3536029504, ; 196: Xamarin.Forms.Platform.Android.dll => 0xd2c38740 => 82
	i32 3567349600, ; 197: System.ComponentModel.Composition.dll => 0xd4a16f60 => 114
	i32 3608519521, ; 198: System.Linq.dll => 0xd715a361 => 98
	i32 3618140916, ; 199: Xamarin.AndroidX.Preference => 0xd7a872f4 => 67
	i32 3627220390, ; 200: Xamarin.AndroidX.Print.dll => 0xd832fda6 => 68
	i32 3632359727, ; 201: Xamarin.Forms.Platform => 0xd881692f => 83
	i32 3633644679, ; 202: Xamarin.AndroidX.Annotation.Experimental => 0xd8950487 => 30
	i32 3641597786, ; 203: Xamarin.AndroidX.Lifecycle.LiveData.Core => 0xd90e5f5a => 55
	i32 3672681054, ; 204: Mono.Android.dll => 0xdae8aa5e => 7
	i32 3676310014, ; 205: System.Web.Services.dll => 0xdb2009fe => 115
	i32 3682565725, ; 206: Xamarin.AndroidX.Browser => 0xdb7f7e5d => 36
	i32 3684561358, ; 207: Xamarin.AndroidX.Concurrent.Futures => 0xdb9df1ce => 39
	i32 3689375977, ; 208: System.Drawing.Common => 0xdbe768e9 => 88
	i32 3718780102, ; 209: Xamarin.AndroidX.Annotation => 0xdda814c6 => 29
	i32 3724971120, ; 210: Xamarin.AndroidX.Navigation.Common.dll => 0xde068c70 => 64
	i32 3754567612, ; 211: SQLitePCLRaw.provider.e_sqlite3 => 0xdfca27bc => 17
	i32 3758932259, ; 212: Xamarin.AndroidX.Legacy.Support.V4 => 0xe00cc123 => 53
	i32 3786282454, ; 213: Xamarin.AndroidX.Collection => 0xe1ae15d6 => 38
	i32 3822602673, ; 214: Xamarin.AndroidX.Media => 0xe3d849b1 => 62
	i32 3829621856, ; 215: System.Numerics.dll => 0xe4436460 => 22
	i32 3876362041, ; 216: SQLite-net => 0xe70c9739 => 11
	i32 3885922214, ; 217: Xamarin.AndroidX.Transition.dll => 0xe79e77a6 => 74
	i32 3896760992, ; 218: Xamarin.AndroidX.Core.dll => 0xe843daa0 => 43
	i32 3920810846, ; 219: System.IO.Compression.FileSystem.dll => 0xe9b2d35e => 113
	i32 3921031405, ; 220: Xamarin.AndroidX.VersionedParcelable.dll => 0xe9b630ed => 77
	i32 3928044579, ; 221: System.Xml.ReaderWriter => 0xea213423 => 102
	i32 3931092270, ; 222: Xamarin.AndroidX.Navigation.UI => 0xea4fb52e => 66
	i32 3945713374, ; 223: System.Data.DataSetExtensions.dll => 0xeb2ecede => 111
	i32 3955647286, ; 224: Xamarin.AndroidX.AppCompat.dll => 0xebc66336 => 32
	i32 4025784931, ; 225: System.Memory => 0xeff49a63 => 21
	i32 4073602200, ; 226: System.Threading.dll => 0xf2ce3c98 => 105
	i32 4087494849, ; 227: SQLiteNetExtensionsAsync.dll => 0xf3a238c1 => 13
	i32 4105002889, ; 228: Mono.Security.dll => 0xf4ad5f89 => 116
	i32 4151237749, ; 229: System.Core => 0xf76edc75 => 19
	i32 4181436372, ; 230: System.Runtime.Serialization.Primitives => 0xf93ba7d4 => 94
	i32 4182413190, ; 231: Xamarin.AndroidX.Lifecycle.ViewModelSavedState.dll => 0xf94a8f86 => 59
	i32 4260525087, ; 232: System.Buffers => 0xfdf2741f => 18
	i32 4292120959 ; 233: Xamarin.AndroidX.Lifecycle.ViewModelSavedState => 0xffd4917f => 59
], align 4
@assembly_image_cache_indices = local_unnamed_addr constant [234 x i32] [
	i32 57, i32 86, i32 9, i32 81, i32 71, i32 71, i32 38, i32 72, ; 0..7
	i32 36, i32 99, i32 52, i32 107, i32 93, i32 115, i32 41, i32 56, ; 8..15
	i32 50, i32 28, i32 22, i32 54, i32 16, i32 21, i32 40, i32 80, ; 16..23
	i32 92, i32 49, i32 94, i32 8, i32 20, i32 50, i32 61, i32 100, ; 24..31
	i32 110, i32 10, i32 104, i32 113, i32 45, i32 77, i32 33, i32 27, ; 32..39
	i32 14, i32 112, i32 13, i32 88, i32 68, i32 93, i32 86, i32 9, ; 40..47
	i32 54, i32 5, i32 91, i32 92, i32 70, i32 32, i32 83, i32 96, ; 48..55
	i32 58, i32 20, i32 75, i32 65, i32 33, i32 76, i32 15, i32 47, ; 56..63
	i32 98, i32 89, i32 87, i32 70, i32 2, i32 62, i32 42, i32 24, ; 64..71
	i32 104, i32 84, i32 112, i32 31, i32 101, i32 1, i32 0, i32 46, ; 72..79
	i32 4, i32 12, i32 60, i32 97, i32 79, i32 44, i32 3, i32 101, ; 80..87
	i32 25, i32 73, i32 85, i32 12, i32 41, i32 99, i32 16, i32 95, ; 88..95
	i32 37, i32 1, i32 72, i32 19, i32 49, i32 60, i32 85, i32 66, ; 96..103
	i32 106, i32 96, i32 80, i32 84, i32 34, i32 2, i32 63, i32 18, ; 104..111
	i32 58, i32 55, i32 25, i32 23, i32 51, i32 17, i32 82, i32 100, ; 112..119
	i32 3, i32 75, i32 61, i32 63, i32 53, i32 69, i32 29, i32 102, ; 120..127
	i32 67, i32 103, i32 14, i32 40, i32 108, i32 6, i32 111, i32 57, ; 128..135
	i32 107, i32 76, i32 106, i32 44, i32 48, i32 56, i32 91, i32 89, ; 136..143
	i32 73, i32 90, i32 28, i32 10, i32 31, i32 81, i32 78, i32 42, ; 144..151
	i32 26, i32 78, i32 74, i32 97, i32 95, i32 114, i32 8, i32 79, ; 152..159
	i32 23, i32 30, i32 47, i32 52, i32 5, i32 64, i32 90, i32 4, ; 160..167
	i32 109, i32 46, i32 0, i32 105, i32 116, i32 37, i32 35, i32 11, ; 168..175
	i32 103, i32 45, i32 109, i32 34, i32 65, i32 51, i32 15, i32 43, ; 176..183
	i32 6, i32 69, i32 24, i32 87, i32 26, i32 108, i32 48, i32 7, ; 184..191
	i32 110, i32 39, i32 35, i32 27, i32 82, i32 114, i32 98, i32 67, ; 192..199
	i32 68, i32 83, i32 30, i32 55, i32 7, i32 115, i32 36, i32 39, ; 200..207
	i32 88, i32 29, i32 64, i32 17, i32 53, i32 38, i32 62, i32 22, ; 208..215
	i32 11, i32 74, i32 43, i32 113, i32 77, i32 102, i32 66, i32 111, ; 216..223
	i32 32, i32 21, i32 105, i32 13, i32 116, i32 19, i32 94, i32 59, ; 224..231
	i32 18, i32 59 ; 232..233
], align 4

@marshal_methods_number_of_classes = local_unnamed_addr constant i32 0, align 4

; marshal_methods_class_cache
@marshal_methods_class_cache = global [0 x %struct.MarshalMethodsManagedClass] [
], align 4; end of 'marshal_methods_class_cache' array


@get_function_pointer = internal unnamed_addr global void (i32, i32, i32, i8**)* null, align 4

; Function attributes: "frame-pointer"="none" "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" "stackrealign" "target-cpu"="i686" "target-features"="+cx8,+mmx,+sse,+sse2,+sse3,+ssse3,+x87" "tune-cpu"="generic" uwtable willreturn writeonly
define void @xamarin_app_init (void (i32, i32, i32, i8**)* %fn) local_unnamed_addr #0
{
	store void (i32, i32, i32, i8**)* %fn, void (i32, i32, i32, i8**)** @get_function_pointer, align 4
	ret void
}

; Names of classes in which marshal methods reside
@mm_class_names = local_unnamed_addr constant [0 x i8*] zeroinitializer, align 4
@__MarshalMethodName_name.0 = internal constant [1 x i8] c"\00", align 1

; mm_method_names
@mm_method_names = local_unnamed_addr constant [1 x %struct.MarshalMethodName] [
	; 0
	%struct.MarshalMethodName {
		i64 0, ; id 0x0; name: 
		i8* getelementptr inbounds ([1 x i8], [1 x i8]* @__MarshalMethodName_name.0, i32 0, i32 0); name
	}
], align 8; end of 'mm_method_names' array


attributes #0 = { "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" uwtable willreturn writeonly "frame-pointer"="none" "target-cpu"="i686" "target-features"="+cx8,+mmx,+sse,+sse2,+sse3,+ssse3,+x87" "tune-cpu"="generic" "stackrealign" }
attributes #1 = { "min-legal-vector-width"="0" mustprogress "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" uwtable "frame-pointer"="none" "target-cpu"="i686" "target-features"="+cx8,+mmx,+sse,+sse2,+sse3,+ssse3,+x87" "tune-cpu"="generic" "stackrealign" }
attributes #2 = { nounwind }

!llvm.module.flags = !{!0, !1, !2}
!llvm.ident = !{!3}
!0 = !{i32 1, !"wchar_size", i32 4}
!1 = !{i32 7, !"PIC Level", i32 2}
!2 = !{i32 1, !"NumRegisterParameters", i32 0}
!3 = !{!"Xamarin.Android remotes/origin/d17-5 @ a8a26c7b003e2524cc98acb2c2ffc2ddea0f6692"}
!llvm.linker.options = !{}
