import { useEffect, useState } from "react";
import PostCard from "./PostCard";
import { Post } from "./entities/types";

export default function PostList() {
  const [articles, setArticles] = useState<Post[]>([]);
  useEffect(() => {
    const api = async () => {
      const response = await fetch("http://localhost:5022/api/posts", {
        method: "GET",
      });
      const jsonData = await response.json();
      setArticles(jsonData);
    };
    api();
  }, []);

  return (
    <>
      <div className="container-fluid px-4">
        <div className="row justify-content-around">
          {articles.map((art) => {
            return <PostCard key={art.postId} value={art} />;
          })}
        </div>
      </div>
    </>
  );
}
