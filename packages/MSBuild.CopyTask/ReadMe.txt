*.csproj  ���

<UsingTask TaskName="CopyTask" AssemblyFile="bin\MSBuild.CopyTask.dll" />
  <Target Name="AfterBuild">
    <CopyTask />
  </Target>