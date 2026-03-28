#!/bin/bash
# 修复所有新文件的callback参数顺序
for file in TencentIMClient.{Community,CommunityPermission,CommunityPermissionMember,CommunityTopicPermission,Follow,OfficialAccount,OfflinePush}.cs; do
  sed -i 's/IntPtr\.Zero, IntPtr\.Zero/(TIMCommCallback?)null, IntPtr.Zero/g' "$file"
done
