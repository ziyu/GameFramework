using GameFramework.Resource;

namespace GameFramework.UI
{
    /// <summary>
    /// UI 资源辅助器
    /// </summary>
    public interface IUIResourceHelper
    {

        /// <summary>
        /// 设置资源管理器
        /// </summary>
        /// <param name="resourceManager"></param>
        void SetResourceManager(IResourceManager resourceManager);

        /// <summary>
        /// 加载UI资源
        /// </summary>
        /// <param name="assetName">资源名称</param>
        /// <param name="priority">优先级</param>
        /// <param name="loadAssetCallbacks">加载资源回调</param>
        /// <param name="userData">用户定义数据</param>
        void LoadAsset(string assetName, int priority, LoadAssetCallbacks loadAssetCallbacks, object userData);
    }
}
