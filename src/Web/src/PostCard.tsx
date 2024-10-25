import { Post } from "./entities/types";

export default function PostCard({ value }: { value: Post }) {
  return (
    <div className="card col m-2 card-size">
      <div className="card-body">
        <h5 className="card-title">{value.title}</h5>
      </div>

      <div className="card-footer text-muted text-end">
        {`${value.createdAt.split("T")[0]}`}
      </div>
    </div>
  );
}
