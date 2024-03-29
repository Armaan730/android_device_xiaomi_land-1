#
# Copyright (C) 2017 The LineageOS Project
# Copyright (C) 2017 The XPerience Project
#
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
#
# http://www.apache.org/licenses/LICENSE-2.0
#
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
#
[AID_QTI_DIAG]
value:2901

[vendor/bin/imsdatadaemon]
user: AID_SYSTEM
group: AID_SYSTEM
mode: 0755
caps: NET_BIND_SERVICE

[vendor/bin/ims_rtp_daemon]
user: AID_SYSTEM
group: AID_RADIO
mode: 0755
caps: NET_BIND_SERVICE

[system/bin/pm-service]
user: AID_SYSTEM
group: AID_SYSTEM
mode: 0755
caps: NET_BIND_SERVICE

[vendor/bin/pm-service]
user: AID_SYSTEM
group: AID_SYSTEM
mode: 0755
caps: NET_BIND_SERVICE

[vendor/bin/pm-service]
user: AID_SYSTEM
group: AID_SYSTEM
mode: 0755
caps: NET_BIND_SERVICE

[system/bin/wcnss_filter]
user: AID_BLUETOOTH
group: AID_BLUETOOTH
mode: 0755
caps: BLOCK_SUSPEND

[vendor/bin/qvrservice]
user: AID_SYSTEM
group: AID_SYSTEM
mode: 0755
caps: SYS_NICE

[system/bin/cnss-daemon]
user: AID_SYSTEM
group: AID_SYSTEM
mode: 0755
caps: NET_BIND_SERVICE

[vendor/bin/cnd]
mode: 0755
user: AID_SYSTEM
group: AID_SYSTEM
caps: NET_BIND_SERVICE BLOCK_SUSPEND NET_ADMIN

[vendor/bin/cnd]
mode: 0755
user: AID_SYSTEM
group: AID_SYSTEM
caps: NET_BIND_SERVICE BLOCK_SUSPEND NET_ADMIN

[vendor/bin/slim_daemon]
mode: 0755
user:  AID_GPS
group: AID_GPS
caps: NET_BIND_SERVICE

[vendor/bin/slim_daemon]
mode: 0755
user:  AID_GPS
group: AID_GPS
caps: NET_BIND_SERVICE

[vendor/bin/xtwifi-client]
mode: 0755
user:  AID_GPS
group: AID_GPS
caps: NET_BIND_SERVICE BLOCK_SUSPEND

[bin/xtwifi-client]
mode: 0755
user:  AID_GPS
group: AID_GPS
caps: NET_BIND_SERVICE BLOCK_SUSPEND

